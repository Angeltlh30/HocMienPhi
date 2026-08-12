using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.service.Utils.Mail;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace DOTNET_hocmienphi.service.Utils.BackgroundJob;

[DisallowConcurrentExecution] 
//Bắt buộc 1 lúc chỉ có 1 luồng thực thi công việc này, task trước hoàn thành thì mới chạy tiếp
public class SendAdvertisingJob : IJob
{
    private readonly AppDbContext _dbContext;
    private readonly IService _mailService;
    
    public SendAdvertisingJob(AppDbContext dbContext, IService mailService)
    {
        _dbContext = dbContext;
        _mailService = mailService;
    }
    
    public async Task Execute(IJobExecutionContext context)
    {
        DateOnly todayDate = DateOnly.FromDateTime(
            TimeZoneInfo.ConvertTime(
                DateTimeOffset.UtcNow,
                TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")
            ).DateTime
        );
        var batchSize = 50;
        var notSendTodayUsers =
            await GetBatchUsersNotSendMailToday(todayDate, batchSize);

        await SendBatchMail(notSendTodayUsers, todayDate);
        
        _dbContext.Users.UpdateRange(notSendTodayUsers);
        await _dbContext.SaveChangesAsync();

    }

    public async Task<List<User>> GetBatchUsersNotSendMailToday(DateOnly today, int batchSize)
    {
        var query = _dbContext.Users
            .Where(u => u.IsDeleted == false);
        
        query = query.Where(u => u.SendDate < today);
        query = query
            .OrderBy(u => u.Id)
            .Take(batchSize);
        
        var result = await query.ToListAsync();
        return result;
    }

    public async Task SendBatchMail(List<User> users, DateOnly today)
    {
        // var taskList =new List<Task>();
        // foreach (var x in users)
        // {
        //     var mailContent = new MailContent()
        //     {
        //         To = x.Email,
        //         Subject = "Chương trình khuyến mãi",
        //         Body = "Chào bạn, chúng tôi có chương trình khuyến mãi hấp dẫn dành cho bạn!"
        //     };
        //     var userTask = Task.Run(async () =>
        //     {
        //         await _mailService.SendMail(mailContent);
        //     });
        //     taskList.Add(userTask);
        //     x.SendDate = today;
        // }
        
        var tasks = users.Select(async user =>
        {
            try
            {
                var mailContent = new MailContent
                {
                    To = user.Email,
                    Body = "HT",
                    Subject = "HT"
                };

                await _mailService.SendMail(mailContent);
                user.SendDate = today; // chỉ set khi gửi THÀNH CÔNG
            }
            catch (Exception ex)
            {
                // log lỗi, KHÔNG set SendDate -> lần chạy job sau sẽ tự động thử lại user này
            }
        });

        await Task.WhenAll(tasks);
    }
}

public static class TimeZoneUtils
{
    public static TimeZoneInfo GetVietNamTimeZone()
    {
        try
        {
            return  TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
        }
        catch (TimeZoneNotFoundException)
        {
            return TimeZoneInfo.FindSystemTimeZoneById("Asia/Ho_Chi_Minh");
        }
    }
}

    // Background Job:
    // Là 1 tác vụ được thực thi ngầm,
    // Tách biệt khỏi luồng xử lý chính
    // Tác vụ này do hệ thống thực thi
    // Khi nào server mình sẽ chạy công việc này:
        // Setup định kỳ (CronJob)
        // + Cứ mỗi 7h sáng là gửi thư quảng cáo cho khách hàng
        // + Nếu muốn (IsDeleted = true), theo thời gian
        // những record xoá mềm sẽ tăng lên,
        // những dòng record này là những dòng chúng ta ko đụng đến
        // => Dữ liệu dư thừa, database nặng lên,
        // định kì phải xoá nó đi, 1 tuần xoá 1 lần.
        
    //Là mình sẽ nhờ n thay mih làm cv này giúp mình
        //CÓ 1 ham Register
        //Xg DB kiểm tra email tồn tại (10ms)
        //Tính toán để tạo MK hashing (2ms)
        //Lưu user này vào database (5ms)
        //Gửi email thông báo verify tài khoản (10s)
    //Logic gửi email là 1 logic rât nặng và tốn nhiều thgian để hoàn thành
        //Mình có thể chọn khi user bấm register khỏi cho đợi mail mà trả ra response luôn
        //Cái việc mà gửi email thông báo sẽ do luồng Background Job gửi
    
        // Bây giờ tôi muốn gửi mail cho tất cả các user trong hệ thống vào lúc 7 sáng.
        // Đối với user ít, tầm 20 thằng thì ngon ơ rồi.
            // Cứ 7h sáng là lấy ra 1 đống user ra gửi mail thôi
        // Đối với 1.000.000 user thì sao, 1.000.000 * 20s.
           // Xài Task.WhenAll để gửi
          // (Trong vòng 20s đó, có 1000 thằng được gửi mail)
          // (Vậy thì trong vòng 5giờ, sẽ gửi xong mail cho 1000000 thằng)
        // // À anh ơi, tại sao mình không trong vòng 20s mình gửi 1 lượt 1000 thằng luôn đi
        // Một 1 Task được ra, giống như mở thêm 1 luồng bất đồng bộ
        // Server xử lí 1tr luồng cùng 1 lúc không nổi !
        // Nên là mình đặt thời gian lại, dài hơn 1 xíu, 1 lần gửi 1000 thằng thôi
        // Nhưng server vẫn chịu được và sống tốt

        // Thêm 1 problem nữa, bây giờ mình chỉ gửi mail 1 lúc 1000 thằng thôi,
        //     vậy thi bây g cta phai co 1 cái gì đó đánh dấu
        //      à tôi nghĩ ngay isSend, ngon lành luôn, siêu System Design
        //      Cái IsSend này chỉ ngon khi dữ liệu đụng đến 1 lan r thôi
        // Ví dụ trang thái đơn hàng, isPending, nếu trong vòng 1h không thanh toán 
                //-> chuyển thành isFail, rôì kh đụng tới nữa
        //Với IsSend -> neu để isSend ở User, mình sẽ không biết được ngày nào, đã gửi hay chưa
        