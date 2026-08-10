using DOTNET_hocmienphi.api.Extensions;
using DOTNET_hocmienphi.api.Middlewares;
using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.service.Utils.JWTService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserService = DOTNET_hocmienphi.service.UserService;
using MailService = DOTNET_hocmienphi.service.Utils.Mail;
using CloudinaryService = DOTNET_hocmienphi.service.Utils.CloudinaryService;
using MediaService = DOTNET_hocmienphi.service.Utils.MediaService;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Service de cài bộ đồ chơi
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);
builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddSwaggerServices();

builder.Services.AddScoped<UserService.IService, UserService.Service>();
builder.Services.AddScoped<MailService.IService, MailService.Service>();
builder.Services.AddScoped<MediaService.IService, CloudinaryService.Service>();
//middleware
builder.Services.AddTransient<GlobalExceptionHandlerMiddleware>();

//từ dòng app này trở lên trên, khai báo những đồ chơi mà mình xa
var app = builder.Build();

//từ dòng app này trở xg, apply những đo chơi vào server, quan trọng thu tự apply
// Configure the HTTP request pipeline.

app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
// Đặt middleware này ở đầu tiên để bắt tất cả các exception
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
    app.UseSwaggerAPI();
}

app.UseAuthentication(); //Authen trước author
app.UseAuthorization();

app.MapControllers();

app.Run();


//1 quá trình phát triển phần mềm thường sẽ trải qua:
    //Đi tìm hiểu nhu cầu của khách hàng
    //Hiểu đc nhu caau rồi thì phn tích ra các requirement
//Sau đó dựa vào requirement, cta sẽ thiết kế ra hệ thng
    //Thiết kế ra kiến trúc hệ thong
    //Thiết kế ra db (ERD)
//Implement các requirement len code
    //Test các requirement đa đc implement
    //Đóng gói - deploy - giao khách
    //Lụm tiền 
    //Maintain

//nơi cho các học sinh đi vào nền tảng tìm kiếm các mentor de học tập, trao đổi kiến thuc
//Khi mà Mentor muốn apply vào nền tảng, thì phai ền thông thông tin
    //sau đó admin sẽ duyêtk
//Mentor thì đi vào nền tẳng, tạo những lịch ranh và các học sinh sẽ book lịch rảnh đó
//Để 1 User co thể trở thành 1 Mentor
    //User sẽ ddien thông tin de apply tro thanh Mentor
        //1 User sẽ có requirement(ApplyRequest) đẻ become Mentor
            //Ng dung dua file CV -> Upload Cloud
        //Mqh giua User và ApplyRequest (1-N) vì có thể có đơn bi reject hoạặc duyeỵe
            //Nhưng chỉ c 1 đơn đc duyet
        //Khi co User nop don apply thi system thong bao cho admin
            //Duyet: Approved, Reject -> alert for User
    
    //Admin se duyet thong tin đó, neu thong tin hop le thi sẽ duyet
        //User đó bây gio sẽ dc cap thong tin hợp lệ thì sẽ đc duyet
    //Neu dc duyet, thì User đo sẽ become Mentor
    //Chi co User nào có quyen Admin thi moi dc sd APO nhu lay don he thong/phe duyet don


// API:
// Tạo đơn
    // (Dành cho User)
    // POST /api/applyRequest
    //De goi dc request nay can CV va Description
// Lấy các đơn apply của tôi
    // GET /api/applyRequest/me

    // Mentor cần api này để kiểm tra xem tiến độ / tình trạng của đơn

// Lấy tất cả các đơn apply
    // (Dành cho Admin)
    // GET /api/applyRequest

    // Admin cần api này để duyệt đơn apply của người dùng

// Lấy thông tin chi tiết của đơn này
    // GET /api/applyRequest/{id}

    // (Dành cho Admin và User)

// Duyệt đơn apply
    // (Dành cho Admin)
    // POST /api/applyRequest/{id}/review

    // Khi duyệt đơn, thì Admin có thể chọn duyệt hoặc từ chối
    // Nếu từ chối thì phải có lý do từ chối
    // Khi ma duyet don xong thi role phai duoc doi
    // Khi duyệt đơn, thì hệ thống phải thông báo cho User về kết quả của đơn apply đó


//Kĩ thuật snapshot
//Trong năm 2026, anh Tân bán áo với giá là 1000đ
//Sau đó Bảo thấy áo đẹp quá muốn mau cho crush
    //Bảo mua 1 đơn hàng với ID O1,
    //trong đơn hàng có 2 sp, P1 và P2
//Qua thgian, bây giơ là 2027, Tân đổi giá lên 2000đ
//Sau dó Bảo ctay ny và đòi lại quà, lúc đó Bảo cho nhân viên xem lại đơn hàng thì kh chuẩn giá cũ nữa
//Mình sẽ tạo thêm ô nho Price (giá khi mua)

//Kiêến thức SQL: relationship
    //Mqh 1-n: khóa chính của 1 s để qua nhiều
    //tại sao lại xoay mũi tên nhiều vào bảng trung gian?
    //Mqh 1-1
    //Chuẩn dữ liệu là gì
//Cách thết kế DB concept đệ quy
    //Ưu: auto scale-up lên
    //Nhược:

//App này gồm nhiều ng xài
    //Admin:
        //Quản lý User (Học sinh và mentor) của nền tảng
        //Quản lý và phe duyệt đơn de trở thành mentor
    //Mentor
        //Tạo lịch rảnh để hs book
        //Quản ly lịch Book (dời lịch, hủy lichj)
        //Quản lý Profile
    //Học sinh
        //Book lịch rảnh của Mentor
        //Quản lý lịch book (dời lịch, hủy lịch)
        //Quản lý Profile
        
    