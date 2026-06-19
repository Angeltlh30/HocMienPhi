using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.service.CategoryService;

using Microsoft.AspNetCore.Mvc;
using Request = DOTNET_hocmienphi.service.CategoryService.Request;

namespace DOTNET_hocmienphi.api.Controller;

//Để có 1 class Controller thì cần phải có 2 thứ:
//1. Kế thừa từ ControllerBase
//2. Có Annotation [ApiController] để đánh dấu đây là 1 class Controller
[ApiController]
[Route("[controller]")]

//Khai báo API cần 2 bươớc trên và 1 bước nữa là định nghĩa các Endpoint trong Controller đó
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _dbContext; //presented of DB: AppDBContext

    public CategoryController(AppDbContext dbContext)
    {
        _dbContext = dbContext; //inject DBContext vào trong controller để có thể thao tác với DB
    }
    //Dependency Ịnjection: Core
    [HttpGet("")]
    public IActionResult GetAllCategory(string? searchTerm, int? pageIndex = 1, int? pageSize = 10)
    {
        var query = _dbContext.Categories.Where(x => x.IsDeleted == false);
        //Just get parent
        query = query.Where(x => x.ParentId == null);
        query = query.OrderBy(x => x.Name);

        var selectedQuery = query
            .Select(x => new Response.GetCategoryResponse()
        {
            Id = x.Id.ToString(),
            Name = x.Name
        }).ToList();
        //Purpose of create GetAllParentCategoryResponse:
            //Api chỉ càn 2 field Id và Name thôi, nhưng trong db lúc nao cũng quang ra full (id, name, parentID)
            // -> Phí
        //Cacách tối ưu query: 
        var result = selectedQuery.ToList();
        return Ok(result); //Muon result quăng ra swagger thì bỏ vào đây
    } 
    
//Khai báo API sau: 
    //Get All Category
    //Get Category By Id
    [HttpGet("{id}")]
    public IActionResult GetChildrenCategoryByParentId(Guid id)
    {
        var query = _dbContext.Categories.Where(x => x.IsDeleted == false); 
        query = query.Where(x => x.ParentId != null & x.ParentId == id);
        query = query.OrderBy(x => x.Name);
        var selectedQuery = query
            .Select(x => new Response.GetCategoryResponse()
            {
                Id = x.Id.ToString(),
                Name = x.Name
            }).ToList();
        var result = selectedQuery.ToList();
        return Ok("result");
    }
    //Create Category
        //Yêu cầu có body, là name, parentID
    [HttpPost("")]
    public IActionResult CreateCateGory(Request.CreateCategoryRequest requestBody)
    {
        //requestBody sẽ tự động được map với body của request gửi lên, miễn là các field trùng tên
        //body do FE truyeenf cho mình, khi FE go API th nó muốn tạo 1 record - 1 line dưới DB
        //1 line sẽ có các field: id, name, parentId
        
        //Lúc này BE phải tạo ra 1 Object tu class Category
        //Bởi vi Category Table dưới DB đc tạo tu class Category
            //Thế nên đe add data vào table category cần new mơới
            //1 object Category category = new Category();

            var newCategory = new Category()
            {
                Id = Guid.NewGuid(), //id random
                Name = requestBody.Name,
                ParentId = requestBody.ParentId
            };
            _dbContext.Categories.Add(newCategory); //add vào bo nhớ
            _dbContext.SaveChanges(); //lưu vào DB
        //get all user on db
        return Ok("Create Category");
    } 
    //Update Category By Id
    [HttpPut("{id}")] //Route Param
    public IActionResult UpdateCategoryById(Guid id, Request.UpdateCategoryRequest requestBody)
    {
        var query  = _dbContext.Categories.Where(x => x.IsDeleted == false); 
        query = query.Where(x => x.Id == id);
        var category = query.FirstOrDefault();
        if (category != null)
        {
            category.Name = requestBody.Name;
            category.ParentId = requestBody.ParentId;
            
            _dbContext.Categories.Update(category);
            _dbContext.SaveChanges();
        }
        return Ok("This is User have id" + id);
    } 
    
    //Delete Category By Id
    [HttpDelete("{id}")]
    public IActionResult DeleteCategoryById(Guid id)
    {
        //Có id rồi, thì bây giờ mình phải lấy Category trong DB, sau đó xóa 
        var query = _dbContext.Categories.Where(x => x.IsDeleted == false);
        query = query.Where(x => x.Id == id);
        var category = query.FirstOrDefault();
        if (category != null)
        {
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }
        return Ok("This is User have id" + id);
    }
}

