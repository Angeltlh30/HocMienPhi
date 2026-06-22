using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.repository.enums;
using DOTNET_hocmienphi.service.ApplyRequestService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Response = DOTNET_hocmienphi.service.ApplyRequestService.Response;

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
//FE chỉ truyền cho mình 1 List requestBody.Categories
//Nhma những data mà mentor mong muốn đc mentoring category thì nó nằm
    // o bẳng ApplyRequestCategory
    //Vậy nên mih phải an xạ ừ list requestBody.CategoryIds sang list ApplyRequestCategory
//Ánh xạ data : Select
        var applyRequestCategories = requestBody.CategoryIds.Select(
            x => new ApplyRequestCategory() //thể hiện mentor(request) có thể giảng dạy ở phân loại ầo
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
    public IActionResult GetAllApplyRequest(string? searchTerm = null, ApplyRequestStatus? status = null, 
                                            DateTimeOffset? fromDate = null,
                                            DateTimeOffset? toDate = null, 
                                            List<Guid> categoryIds = null,
                                            int pageIndex = 1, int pageSize = 10 ) //để mặc định là null, nếu FE kh truyền thì sẽ là nulllll
    {
        var query = _dbContext.ApplyRequests.Where(
            x => x.IsDeleted == false);
        //search từ khóa 
        if (searchTerm != null)
        {
            query = query.Where(x => 
                    x.Description.Contains(searchTerm) ||
                    x.User.FirstName.Contains(searchTerm) ||
                    x.User.LastName.Contains(searchTerm));                 
        }
        //Truoc g cta chỉ search ở table hiện tại
        //Còn 2 thaằng sau thì update lên 1 tí
        //Lúc ny thì nó se tự động join sang table User để tìm kiếm
        
        //CategoryIds: là nhung CategoryId ma FE muon search/filter
        //Toi muon tim nhung la đơn thuộc loại Category này
        //
        if(categoryIds != null && categoryIds.Count > 0)
        {
            query = query.Where(x => 
                x.ApplyRequestCategories.Any(
                    //any: duyệt qua từng list trong x
                    applyRC => categoryIds.Contains(applyRC.CategoryId)));
        }
            
        if (status != null)
        {
            query = query.Where(x => x.Status == status);
        }
        
        var selectedQuery = 
            query.Select(x => 
                new Response.GetApplyRequestResponse()
            {
                Id = x.Id,
                Description = x.Description,
                CvLink = x.CvLink,
                Status = x.Status,
                RejectReason = x.RejectReason,
                User = new service.UserService.Response.GetUserResponse()
                {
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Email = x.User.Email,
                    Age = x.User.Age
                },
                Categories = x.ApplyRequestCategories.Select(
                    applyRC => new service.CategoryService.Response.GetAllParentCategoryResponse()
                    {
                        Id = applyRC.Category.Id,
                        Name = applyRC.Category.Name
                    }).ToList()
            });
        selectedQuery = selectedQuery.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var result = selectedQuery.ToList();
        return Ok(result); 
    } 
    
    [HttpGet("me")]
    public IActionResult GetMyApplyRequest(Guid userId, ApplyRequestStatus? status = null, 
                                            int pageIndex = 1, int pageSize = 10)
    {
        var query = _dbContext.ApplyRequests.Where(
            x => x.IsDeleted == false);
        query = query.Where(x => x.UserId == userId);
        if (status != null)
        {
            query = query.Where(x => x.Status == status);
        }
        
        var selectedQuery = 
            query.Select(x => 
                new Response.GetApplyRequestResponse()
                {
                    Id = x.Id,
                    Description = x.Description,
                    CvLink = x.CvLink,
                    Status = x.Status,
                    RejectReason = x.RejectReason,
                    User = new service.UserService.Response.GetUserResponse()
                    {
                        FirstName = x.User.FirstName,
                        LastName = x.User.LastName,
                        Email = x.User.Email,
                        Age = x.User.Age
                    },
                    Categories = x.ApplyRequestCategories.Select(
                        applyRC => new service.CategoryService.Response.GetAllParentCategoryResponse()
                        {
                            Id = applyRC.Category.Id,
                            Name = applyRC.Category.Name
                        }).ToList()
                });
        selectedQuery = selectedQuery.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var result = selectedQuery.ToList();

        return Ok(); 
    } 

    
    
    [HttpGet("{id}")]
    public IActionResult GetApplyRequestDetail(Guid id)
    {
        var query = _dbContext.ApplyRequestCategories.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id == id);
        var selectedQuery = query.Select(x => new Response.GetApplyRequestResponse()
        {
            Id = x.ApplyRequest.Id,
            Description = x.ApplyRequest.Description,
            CvLink = x.ApplyRequest.CvLink,
            Status = x.ApplyRequest.Status,
            RejectReason = x.ApplyRequest.RejectReason,
            User = new service.UserService.Response.GetUserResponse()
            {
                FirstName = x.ApplyRequest.User.FirstName,
                LastName = x.ApplyRequest.User.LastName,
                Email = x.ApplyRequest.User.Email,
                Age = x.ApplyRequest.User.Age
            },
            Categories = x.ApplyRequest.ApplyRequestCategories.Select(
                applyRC => new service.CategoryService.Response.GetAllParentCategoryResponse()
                {
                    Id = applyRC.Category.Id,
                    Name = applyRC.Category.Name
                }).ToList()
        });
        
        var result = selectedQuery.FirstOrDefault();
        return Ok(result);
    }
    
    [HttpPost("{id}/review")]
    public IActionResult ReviewApplyRequest(Guid id, Request.ReviewApplyRequestRequest requestBody)
    {
        var query = _dbContext.ApplyRequests.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id == id);
        
        //Include: mỗi đứa lấy lên nhớ đính kèm User (join)
        query = query.Include(x => x.User);
        
        var applyRequest = query.FirstOrDefault();  
        if (applyRequest == null)
        {
            return NotFound("Apply request not found");
        }
        if(requestBody.IsApproved)
        {
            applyRequest.Status = ApplyRequestStatus.Approved;
            applyRequest.User.Role = "Mentor";
            //Có thể bị NULL -> Nullpointer
            // applyRequest.User.Role = "Mentor";
            //Auto join chỉ hđ khi mình sd Select thôi
            //Còn ở đây nếu mà muốn chấm ra User xài ngon ơ thì mình phải sd 
                //Include để join thủ công
            
        }
        else
        {
            applyRequest.Status = ApplyRequestStatus.Rejected;
            applyRequest.RejectReason = requestBody.Reason;
        }
        _dbContext.ApplyRequests.Update(applyRequest);
        _dbContext.SaveChanges();
        
        return Ok();
    } 
}