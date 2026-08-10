using System.Security.Claims;
using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.service.Models;
using DOTNET_hocmienphi.service.UserService;
using DOTNET_hocmienphi.service.Utils.JWTService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_hocmienphi.api.Controller;

[ApiController]
[Route("[controller]")] 
// Note | Annotation
public class UserController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    private readonly IService _userService;
    /*
     * DI - Dependency Injection
     * Nó là 1 tự khoá - lí thuyết rất quan trọng, sương sống của .NET.
     * Các thư viện đều sử dụng DI. Không biết DI thì không code được.
     * Lí thuyết sâu xa thì rất là nhiều, nhưng sử dụng thì chỉ có vài dòng.
     * Lấy ví dụ:
     * + private readonly AppDbContext _dbContext; (Khai báo sử dụng)
     * + public UserController(AppDbContext dbContext, IConfiguration configuration) (Tiêm vào)
       {
           _dbContext = dbContext;
           configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
       }
       Giải thích DI bằng từ từ.
     */
    private readonly JwtOptions _jwtOptions = new();

    public UserController(
        AppDbContext dbContext,
        IConfiguration configuration,
        IService userService)
    {
        _dbContext = dbContext;
        _userService = userService;
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
    }

    /*
     * // Endpoint goi ten khac la cac API
       // VD: POST /api/auth/login //Login
       // VD: POST /api/auth/register //Đăng kí
       // VD: GET /api/users/{id} //Lấy thông tin của 1 User
       // VD: PUT /api/users/{id} //Cập nhật thông tin của 1 User
       // VD: DELETE /api/users/{id} //Xóa 1 User
       
       // Những Endpoint này làm thế nào nó xuất hiện -> Khai báo trong Controller
       
       // Có mấy phương thức | Method của 1 Request
       // GET, POST, PUT, DELETE, PATCH
       // GET: Lấy dữ liệu
       // POST: Tạo mới dữ liệu
       // PUT | PATCH: Cập nhật dữ liệu
       // DELETE: Xóa dữ liệu
       
       //1. Tại sao lại xinh ra các METHOD này
       //2. 1 METHOD mà mình chơi hết cho tất cả được không. VD: 1 POST mình chơi hết, từ Lấy, Tạo, Update, Xoá
       
       // GET khác với POST, PUT, DELETE ở chỗ nào
       // GET: Thường sẽ không có request body, dữ liệu sẽ được truyền qua query hoặc route
       
       // Theo ae có mấy cách để Frontend truyền dữ liệu sang cho BE.
           // Biết là sẽ call API rồi, nhưng mà những cái data mà FE gửi, thì nó sẽ nằm ở đâu trong request
           
       // Thông thường FE sẽ truyền Data qua 3 cách:
           // Query Param: /api/users?name=tan&age=18
               // Là những Param được nằm trên URL và sau dấu ?
               // Như URL ở trên thì chúng ta có 2 Query Param là name = tan và age = 18
           // Route Param: /api/user/{id} | /api/users/1234
               // Là những Param được nằm trên URL và sau dấu /
               // Như URL ở trên thì chúng ta có 1 Route Param là id = 1234
           // Body: Thường sẽ dùng cho POST, PUT, PATCH, DELETE
           
       // Vì GET thông thường sẽ không có BODY, nên chúng ta hạn chế sử dụng cho các API cần bảo mật
       // GET để login: GET /api/auth/login?email=tan&password=123
       // Thông thường khi Login chúng ta thường xài Method là POST /api/auth/login, data sẽ được giấu ở trong body
       
       // Request là gì, 1 yêu cầu xuống server, mong muốn server làm gì đó, và trả về kết quả
       // Ví dụ: 1 HTTP Request Login, mong muốn server xác thực thông tin đăng nhập, và trả về kết quả là Token hoặc lỗi
       // Trong 1 HTTP Request thì sẽ có những thành phần sau:
           // URL: Địa chỉ của API mà chúng ta muốn gọi
           // Method: GET, POST, PUT, DELETE, PATCH
           // Header: Chứa các thông tin về request, như là Content-Type, Authorization, v.v.
           // Body: Chứa dữ liệu mà chúng ta muốn gửi lên server (thường dùng cho POST, PUT, PATCH, DELETE)
           
       // RestFul API: Nó là 1 tiêu chuẩn dùng để thiết kế API,
       // dựa trên các phương thức HTTP và các quy tắc về URL,
       // để tạo ra các API dễ hiểu, dễ sử dụng, và dễ bảo trì
       
       // GetAll: GET /api/user -> Theo chuẩn thì phải đặt các tham số vô để truy vấn
           //  GetAllUsers: GET /api/user/getall
           //  GetAllStaff: GET /api/user/getall-staff
           //  GetAllStudent: GET /api/user/getall-student
       // GetById: GET /api/user/{id}
       // Create: POST /api/user
           // Create User: POST /api/user/create-user
       // Update: PUT /api/user/{id}
       // Delete: DELETE /api/user/{id}
     */
    
    [HttpGet("")] // Query Param: pageIndex, pageSize sẽ thay đổi khi FE truyền vào
    public async Task<IActionResult> GetAllUsers(string? searchTerm, int pageIndex = 1, int pageSize = 10)
    {
        /*
         * Đó giờ, ae mình lập trình trong dự án hiện tại là mình chưa có đề cập gì
         * đến việc lập trình bất đồng bộ - Điều này có nghĩa lí gì.
         * Khi mà N Requests gọi đến cùng 1 lúc thì nó xử lí như thế nào. (Chưa bàn)
         * Đó giờ mình chỉ lập trình Synchronous thôi -
         * Có nghĩa khi mà các request tới, thì nó xử lí tuần tự.
         * Tự đặt ra các câu hỏi như sau:
         * - Vậy thì lập trình bất đồng bộ nghĩa là như thế nào
         * - Lập trình bất đồng bộ có phải thực hiện N Request cùng 1 lúc không
         * - Thực hiện N Request cùng 1 lúc, hình như thấy hơi giống song song - parallel
         * - Vậy thì lúc này Bất Đồng Bộ khác Parallel ở chỗ nào
         *
         * Giải thích Đồng bộ và Bất đồng bộ khác nhau bằng ví dụ Pha Ca Phê
         *
         * Đồng bộ: Nhân viên nhận Order -> Pha cafe -> Đưa khách -> Rồi sau đó mới nhân khách tiếp theo
         * Điểm đặc biệt: Trong lúc pha cafe có hành động là đợi máy xay cafe xong.
         * Thì lúc này nếu có khách tới Order, thằng nhân viên bất đồng bộ sẽ nói rằng:
         * Mày order gì, kệ mẹ mày, tao không cần biết, tao phải đợi máy pha cà phê xay xong đã, rồi tao mới tính tiếp
         *
         * Bất đồng bộ: Linh hoạt hơn, những hành động nào cần chờ đợi như là (đợi máy xay cafe xay xong) thì chủ động
         * bỏ qua và nhận 1 hành động mới (Chẳng hạn như có khách mới order nước). Sau đó máy pha cafe xay xong
         * thì mình nhận kết quả và pha ly nước cho khách cũ.
         *
         * Thông thường mình cứ nghĩ, bất đồng bộ là người nhân viên xử lí 2 order cùng lúc, nhưng không phải,
         * nó là 1 dạng làm việc thông minh
         *
         * Giải thích Bất đồng bộ và Song Song (Parallel) qua ví dụ Quản Lí Nhà Hàng
         *
         * Nhà hàng PiedTeam chi nhánh C#. Giả sử nhà hàng của anh có 2 nhân viên (Bình và Nam). Nhà hàng phục vụ 2 mảng
         * đồ ăn là Chay và Mặn (Cả 2 Bình và Nam đều có thể làm được hết)
         *
         * Đối với lại Parallel:
         * -> Anh phân công, Bình chỉ được làm đồ Chay thôi
         * -> Anh phân công, Nam chỉ được làm đồ Mặn thôi
         * -> Trường hợp ngon nhất: Nhà hàng nhận được các đơn hàng có khối lượng công việc của Chay và Mặn bằng nhau,
         *      nhân viên phục vụ hết công suất.
         * -> Trường hợp tệ: Bên đồ Chay nổ 100 đơn, bên đồ Mặn nổ 0 đơn. Lúc này bên Bình thì làm việc sấp mặt, bên Nam thì
         *      chill chill, Bình bảo Nam qua phụ, Nam đéo phụ. Vì Sếp Tân đã chia từ đầu rồi mà (Parallel)
         *
         * Đối với lại Bất đồng bộ:
         * -> Các anh em làm việc hoà thuận với nhau. Bên Chay nổ đơn nhiều hơn, cả 2 ae góp tay vào phụ.
         * -> Nếu khi nhà hàng quả tải, lúc này chỉ cần tuyển thêm nhân viên vào thôi.
         *
         * Implement vào Code: Tương tự với Javascript thì .NET cũng có lập trình bất đồng bộ. Bên JS mình có Promise thì
         * bên .NET mình có Task. Promise = Task.
         *
         * .NET cũng có Async và Await.
         * -> Async thì đánh giá Method này là 1 hành động bất đồng bộ
         * -> Await: Hãy để phương thức này được thực thi cho đến khi hoàn tất, lúc này mình tranh thủ đi làm cái khác.
         * Khi mà mình Await trong 1 cái hàm, thì mình phải khai báo cái hàm đó là Async.
         * Khi mà mình đánh dấu 1 hàm là Async (Bất đồng bộ á). Thì có nghĩa rằng là cái hàm này sẽ hứa trả cho bạn 1 kết quả
         * (Thì hứa Promise = Task). Lúc này 1 cái hàm Async phải bắt buộc trả ra Task.
         * Quy tắc định nghĩa Task như thế nào:
         * -> 1 cái hàm thì đầu ra (Response) thông thường có 2 gía trị:
         *    + Void                        -> Task
         *    + 1 List...., 1 kiểu gì đó.   -> Task<List<Student> | Task<int> | Task<string>
         *
         * Bất đồng bộ trong .NET thì nó còn có 2 cái hàm đặc biệt nữa là WhenAll và WhenAny
         *
         * Thì WhenAll này để làm gì.
         * Ví dụ: Trong 1 cái Logic nó có 3 cái Function đều là bất đồng bộ hết
         * + Function 1 thì 3s
         * + Function 2 thì 2s
         * + Function 3 thì 4s
         *
         * Đối với logic bình thường
         * await func1
         * await func2
         * await func3
         * -> Tổng thời gian mà hàm này xử lí sẽ là 9s
         *
         * Đối với lại khi mình xài WhenAll
         * -> Nó sẽ lấy cả 3 kết quả cùng 1 lúc dựa trên func trả ra kết quả lâu nhất (funct4)
         * -> Tổng thời gian sẽ là 4s
         * -> Nhưng mà nếu có 1 Task bị lỗi thì cả đám sẽ dừng luôn
         * var result = await Task.WhenAll(func1, func2, func3);
         *
         * Đối với lại khi mình xài WhenAny
         * -> Nó sẽ lấy cả 1 kết quả trả ra nhanh nhất
         * -> Tổng thời gian sẽ là 2s
         * -> Nhưng mà nếu có 1 Task bị lỗi thì hàm sẽ vẫn tiếp tục chạy, đảm bảo thằng nào trả ra nhanh nhất và ko lỗi 
         * var result = await Task.WhenAny(func1, func2, func3);
         *
         * Vậy thì câu hỏi đặt ra. À vậy thôi mình xài WhenAll hết cho rồi, nhanh nhất mà đúng không.
         * Xài cách bth, khi những kết quả của các hàm phụ thuộc lên nhau.
         *   + Ví dụ luồng tạo tài khoản, 3 công việc phụ thuộc vào kết quả của nhau
         *     -> Truy vấn xuống DB xem user có tồn tại hay không
         *     -> Tạo account và lưu xuống Database
         *     -> Nếu tạo account thành công thì gửi email chúc mừng
         * Xài WhenAll khi những kết quả của từng hàm không phụ thuộc lên nhau.
         *   + Ví dụ luồng là tạo Mentor, FE đưa cho mình 2 thứ là UserId và CategoryIds
         *     -> Mình phải verify UserId và CategoryIds thực sự có tồn tại hay không, nếu ko tồn tại bị lỗi Foreignkey
         *     -> Thì ở trường hợp này, 2 hành động không phụ thuộc lẫn nhau, nên xài WhenAll là tối ưu nhất.
         * Xài WhenAny khi mình muốn kiểm tra Service nào nhanh nhất
         *   + Thông thường sẽ được xài trong Load Balancer. 1 trong hệ thống lớn thì sẽ có nhiều service.
         *   + 1 Request sẽ được call tới 3 Service cùng 1 lúc, luôn luôn đảm bảo có sẽ có 1 thằng trả ra kết quả
         */
        var result = await _userService.GetAllUser(searchTerm, pageIndex, pageSize);
        // Lấy tất cả User trong database
        return Ok(result);
    }
    
    [HttpPost("register")] // Body: Dữ liệu sẽ được truyền qua body, nên không cần phải đặt tham số trong URL
    public async Task<IActionResult> CreateUser(Request.CreateUserRequest requestBody)
    //Request.CreateUserRequest request
    {
        var result = await _userService.CreateUser(requestBody);
        return Ok(result);
    }
    
    [HttpGet("{id}")] // Route Param: Id sẽ thay đổi khi FE truyền vào
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        
        query = query.Where(x => x.Id.Equals(id));

        var selectedQuery = query.Select(x => new Response.GetUserResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Age = x.Age,
            Email = x.Email
        });
            
        var result = await selectedQuery.FirstOrDefaultAsync();
        
        return Ok(result);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUserById(Guid id)
    {
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        
        query = query.Where(x => x.Id == id);
        
        var user = query.FirstOrDefault();

        if (user != null)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
        
        return Ok("Đây là User có id là " + id);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUserById(Guid id, Request.UpdateUserRequest requestBody)
    {
        var result = await _userService.UpdateUserById(id, requestBody);
        return Ok(result);
    }
    
    [HttpPost("Login")]
    public async Task <IActionResult> Login(string email, string password)
    {
        var result = await _userService.Login(email, password);
        return Ok(ResponseBuilder.SuccessResponse(result, "Login Successfully", HttpContext.TraceIdentifier));
    }
    
    [HttpPost("ForgotPassword")]
    public IActionResult ForgotPassword()
    {
        // Lấy tất cả User trong database
        return Ok("Đây là tất cả User trong database");
    }
}
