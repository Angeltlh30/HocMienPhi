using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.repository.enums;
using DOTNET_hocmienphi.service.ApplyRequestService;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_hocmienphi.api.Controller;

[ApiController]
[Route("[controller]")]
public class ApplyRequestController : ControllerBase
{
    private readonly AppDbContext _dbContext; //presented of DB: AppDBContext

    public ApplyRequestController(AppDbContext dbContext)
    {
        _dbContext = dbContext; //inject DBContext vào trong controller để có thể thao tác với DB
    }
    // Flow thiết kế API như thế nào
        // Xác định có những API nào
        // API này sẽ làm nhiệm vụ gì
        // Xác định các endpoint (Method, Url)
        // Ai sẽ gọi API này
        // Ngay lập tức chui zô Controller khai luôn
        // Để nó ra 1 cái Swagger cho An Tâm
    //De lam hanh dong này thì can nhung yeu cau gi (Input)
        //Ngay lap tuc list ra luôn
        //Đi vao Entity ngắm nghĩa xem có field gì
        //Sau khi xdinh đc Input rồi, vào Service
            //chui vao folder Request tạo luôn
    
        //Roi lap do choi vao API ma no can o Controller
        //Sau khi xd đc input là gì
        //Hỏi FE can trả thêm gì k
        //Nếu cần thì vào Service tạo class Response
        //Kh -> thì th
    //Sau khi Controller đủ đồ chơi r, có Input và Output r
        //Implement logic xử lý bên trong
    [HttpPost("")]
    public IActionResult CreateApplyRequest(
        Request.CreateApplyRequestRequest requestBody
    )
    {
        var request = new ApplyRequest()
        {
            Id = Guid.NewGuid(),
            UserId = requestBody.UserId,
            Description = requestBody.Description,
            CvLink = requestBody.CvLink,
            Status = ApplyRequestStatus.Pending
        };
        _dbContext.ApplyRequests.Add(request);
        _dbContext.SaveChanges();
        // Apply Request Category là bảng lưu trữ những lĩnh vực
// mà người Mentor apply

// FE: public List<Guid> CategoryIds { get; set; }

// Trong Database thì lưu trữ bằng Entity ApplyRequestCategory

/*
public class ApplyRequestCategory : BaseEntity<Guid>
{
    public Guid ApplyRequestId { get; set; }
    public ApplyRequest ApplyRequest { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
*/
//Làm sao để biêến 1 list<guid> thanh 1 list<ApplyRequestCategory>
//Dùng select ánh xạ, x tuong trung 1 CategoryId
        var applyRequestCategories = requestBody.CategoryIds.Select(x => new ApplyRequestCategory()
        {
            Id = Guid.NewGuid(),
            ApplyRequestId = request.Id,
            CategoryId = x
        });
        _dbContext.ApplyRequestCategories.AddRange(applyRequestCategories);
        _dbContext.SaveChanges();
        return Ok("Create");
    } 
    
    [HttpGet("")]
    public IActionResult GetAllApplyRequest()
    {
        
       
        return Ok(); 
    } 
    
    [HttpGet("me")]
    public IActionResult GetMyApplyRequest()
    {

        return Ok(); 
    } 

    
    
    [HttpGet("{id}")]
    public IActionResult GetApplyRequestDetail(Guid id)
    {
        
        return Ok("result");
    }
    
    [HttpPost("{id}/review")]
    public IActionResult ReviewApplyRequest(Guid id)
    {
        
        return Ok("Create");
    } 
}