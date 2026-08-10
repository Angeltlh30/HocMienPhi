using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.service.MentorService;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_hocmienphi.api.Controller;

[ApiController]
[Route("[controller]")]
public class MentorController : ControllerBase
{
    //Lay tat cả Mentor có trong system
    //Response trả ra
    //Tên, email, organizeName, Level, categories
    private readonly AppDbContext _dbContext;
    
    public MentorController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("")]
    public IActionResult GetAllMentors(
        string? searchTerm = null,
        int pageIndex = 0,
        int pageSize = 10)
    {
        var query = _dbContext.Mentors.Where(x => x.IsDeleted == false);
        if(searchTerm != null)
        {
            query = query.Where(
                x => x.User.FirstName.Contains(searchTerm) ||
                                x.User.LastName.Contains(searchTerm));
            
        }
        var selectedQuery = query.Select(x => new Response.MentorResponse()
        {
            Id = x.Id,
            FirstName = x.User.FirstName,
            LastName = x.User.LastName,
            Email = x.User.Email,
            OrganizationName = x.OrganizationName,
            CurrentPosition = x.CurrentPosition,
            Categories = x.MentorCategories.Select(mc => new service.CategoryService.Response.GetAllParentCategoryResponse()
            {
                Id = mc.Category.Id,
                Name = mc.Category.Name
            }).ToList()
        });
        //PHan trang
        selectedQuery = selectedQuery.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var result = selectedQuery.ToList();
        return Ok(result);
    }
}