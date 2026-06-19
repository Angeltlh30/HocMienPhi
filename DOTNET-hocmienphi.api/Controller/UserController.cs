using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_hocmienphi.api.Controller;

[ApiController]
[Route("[controller]")]
//Note || Annotation
public class UserController: ControllerBase
{
    //Controller: Noi định nghĩa endpoint
    //Endpoint gọi tên khác ầ các APIS
    //VD: POST/api/auth/login
    //    GET/api/auth/register
    //    GET/api/user{id} -- lây thông tin user theo id
    //    PUT/api/user{id} -- cập nhật thông tin user theo id
    //    DELETE/api/user{id} -- xóa thông tin user theo id
    
    //Cách những Endpoint xuất hiện: khai báo trong Controller
    //Các method 1 Request: GET, POST, PUT, DELETE, PATCH
    //  GET: Lấy thông tin
    //  POST: Tạo mới
    //  PUT: Cập nhật toàn bộ thông tin
    //  PATCH: Cập nhật 1 phần thông tin
    //  DELETE: Xóa dữ lieệu
    
    //Lí do sinh ra những method và 1 method xai cho all đuọc không?
    
    //GET khác với POST, PUT, DELETE ntn
    //GET: Thường kh có Request body, dữ liệu truyền qua query hoặc route
    //Có mấy cách để FE truyền data cho BE: 3 cách
        //Query Param: /api/users?name=abc&age=20
            //Là những param nằm trên URL và sau dấu ?
            //Như URL trên ta có 2 param: name, age
        //Route Param: /api/users/1234 || /api/users/{id}
            //Là những param nằm trên URL và sau dấu /
            //Như URL trên ta có 1 param: id = 1234
        //Body: Thường dùng cho POST, PUT, PATCH, DELETE
        
    //Vì GET thông thường sẽ kh có BODY, nên hạn chế sd cho API cần bảo mật
        //VD: GET cho login: /api/auth/login?email=tan&password=123
        //Nên khi login thường xài method POST: /api/auth/login với body: {email: tan, password: 123}
    
    //Request là 1 yêu cầu xg server, mong muốn server làm và reponse
        //VD: 1 HTTP Request Login, mong muốn server xác thuc thông tin đang nhập và trả về token hoặc error
        //Trong 1 HTTTP Req có những thành phần sau:
            //URL: địa chỉ API mà client muốn gọi
            //Method: POST, GET, PUT,...
            //Header: Chứa các thông tin Req nh Content-Type, Authorization,..
            //Body: Chứa dữ liệu mà client muốn gửi lên server, thường dùng cho POST, PUT, PATCH, DELETE
    
    //Restfull API: Là 1 tiêu chuẩn dùng de thiết kế API
        //Dựa tren các method HTTP và các quy tắc về URL
        //Để tạo ra các API dễ hiểu, de sd, de bảo trì
    //GetALl: GET /api/user
    //GetById: GET /api/user/{id}
    //Create: POST /api/user
    //Update: PUT /api/user/{id}
    //Delete: DELETE /api/user/{id}
        //Để chuẩn Restful API thì ph đặt các tham số và để truy vấn
        
    private readonly AppDbContext _dbContext; //presented of DB: AppDBContext

    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext; //inject DBContext vào trong controller để có thể thao tác với DB
    }
    
    [HttpGet("")] //Query Param
    public IActionResult GetAllUsers(string? searchTerm, int? pageIndex = 1, int? pageSize = 10) //dấu "?" có nghĩa là tham số này có thể null, nếu FE kh truyền thì sẽ là null
                                                                    //còn khi kh có dấu "?" mặc định = 0
    {
        //get all user on db
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        if(!string.IsNullOrEmpty(searchTerm))
        {
            var sanitizerText = searchTerm.ToLower().Trim();;
            query = query
                .Where(x => 
                    x.FirstName.ToLower().Contains(sanitizerText) || 
                    x.LastName.ToLower().Contains(sanitizerText) ||
                    x.Email.ToLower().Contains(sanitizerText)
                );
        }
        query = query.OrderBy(x => x.Email);
        
        //var kiểu mới vì query ban đầu kiểu User, giờ kiểu nó là GetUserResponse
        var selectedQuery = query.Select(x => new Response.GetUserResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Age = x.Age,
            Email = x.Email,
        });
        //phân trang
        selectedQuery = selectedQuery
            .Skip((pageIndex.Value - 1) * pageSize.Value)
            .Take(pageSize.Value);
        var result = selectedQuery.ToList();
        return Ok(result);
    } 
    
    [HttpPost("")]
    public IActionResult CreateUsers(Request.CreateUserRequest requestBody)
    {
        //get all user on db
        var newUser = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = requestBody.FirstName,
            LastName = requestBody.LastName,
            Age = "",
            Email = requestBody.Email,
            Password = requestBody.Password,
            Phone = "",
            Role = "Student"
        };
        _dbContext.Users.Add(newUser); //add vào bo nhớ
        _dbContext.SaveChanges();
        
        return Ok("AddUser thành công");
    } 
    
    [HttpGet("{id}")]
    public IActionResult GetUserById(Guid id)
    {
        //get all user on db
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id.Equals(id));
        var selectedQuery = query.Select(x => new Response.GetUserResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Age = x.Age,
            Email = x.Email,
        });
        var result = selectedQuery.FirstOrDefault();
        return Ok(result);
    } 
    
    [HttpDelete("{id}")] //Route Param: id sẽ thay đổi khi FE truyền vào
    public IActionResult DeleteUserById(Guid id)
    {
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id.Equals(id));
        var user = query.FirstOrDefault();
        if (user != null)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
        return Ok("This is a test");
    } 
    
    [HttpPut("{id}")] //Route Param
    public IActionResult UpdateUserById(Guid id)
    {
        var query  = _dbContext.Users.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id.Equals(id));
        var user = query.FirstOrDefault();
        if (user != null)
        {
            user.FirstName = user.FirstName.ToLower();
            user.LastName = user.LastName.ToLower();
            user.Email = user.Email.ToLower();
            user.Age = user.Age;
            user.Phone = user.Phone;
            user.Password = user.Password;
            
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }
        return Ok("This is User have id" + id);
    } 
    
    [HttpPost("Login")]
    public IActionResult Login()
    {
        return Ok("login");
    } 
    
    [HttpPost("ForgotPassword")]
    public IActionResult ForgotPassword()
    {
        return Ok("ForgotPassword");
    } 
    /*
     * BTVN
     * Tạo mới User
     * GetAllUser theo phân trang and Search, OrderBy các thứ
     * GetUserById
     */
    
        
}