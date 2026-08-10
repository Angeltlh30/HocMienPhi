using System.Security.Claims;
using DOTNET_hocmienphi.repository;
using DOTNET_hocmienphi.repository.entity;
using DOTNET_hocmienphi.service.Utils.JWTService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MailService = DOTNET_hocmienphi.service.Utils.Mail;
using MediaService = DOTNET_hocmienphi.service.Utils.MediaService;
using System.Security.Claims;
namespace DOTNET_hocmienphi.service.UserService;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    private readonly MailService.IService _mailService;
    private readonly MediaService.IService _mediaService;
    private readonly JwtOptions _jwtOptions = new();
    

    public Service(AppDbContext dbContext, MailService.IService mailService, MediaService.IService mediaService, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _mailService = mailService;
        _mediaService = mediaService;
        configuration.GetSection(nameof(JwtOptions)).Bind(_jwtOptions);
    }

    public async Task<List<Response.GetUserResponse>> GetAllUser(string? searchTerm, int pageIndex, int pageSize)
    {
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);

        if (!string.IsNullOrEmpty(searchTerm))
        {
            var sanitizerText = searchTerm.Trim().ToLower();
            
            query = query
                .Where(x => 
                    x.FirstName.ToLower().Contains(sanitizerText) ||
                    x.LastName.ToLower().Contains(sanitizerText) ||
                    x.Email.ToLower().Contains(sanitizerText)
                );
            
            // FirstName: Tan, SearchTerm: an -> Tan.Contains(an) -> True
        }
        
        query = query.OrderBy(x => x.Email);

        var selectedQuery = query.Select(x => new Response.GetUserResponse()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Age = x.Age,
            Email = x.Email
        });
        
        selectedQuery = selectedQuery
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize);
        
        var result = await selectedQuery.ToListAsync();

        return result;
    }

    public async Task<string> CreateUser(Request.CreateUserRequest requestBody)
    {
        var existUser = await _dbContext.Users.AnyAsync(x => x.Email == requestBody.Email);

        if (existUser) throw new Exception("User Exist");
        
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
        
        _dbContext.Users.Add(newUser);

        await _dbContext.SaveChangesAsync();

        var mailContent = new MailService.MailContent()
        {
            Body = MailService.MailTemplates.GetHelloMailTemplate(newUser.FirstName + " " + newUser.LastName),
            To = newUser.Email,
            Subject = "Welcome to Hoc Mien Phi System"
        };

        await _mailService.SendMail(mailContent);

        return "Add User thành công";
    }
    
    public async Task<string> UpdateUserById(Guid id, Request.UpdateUserRequest requestBody)
    {
        var query = _dbContext.Users
            .Where(x => x.IsDeleted == false);
        
        query = query.Where(x => x.Id == id);
        
        var user = query.FirstOrDefault();

        if (user == null) throw new KeyNotFoundException("User not found");
        
        // _dbContext.Categories.Remove(category);
        // _dbContext.SaveChanges();
        user.FirstName = requestBody.FirstName;
        user.LastName = requestBody.LastName;
        user.Age = requestBody.Age;
        user.Email = requestBody.Email;
        user.Phone = requestBody.Phone;
        user.Password = requestBody.Password;

        if (requestBody.Avatar != null)
        {
            var avatarUrl= await _mediaService.UploadImageAsync(requestBody.Avatar);
            user.Avatar = avatarUrl;
        }
            
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();
        
        return "Đây là User có id là " + id;
    }
    
    public async Task<string> Login(string email, string password)
    {
        var query = _dbContext.Users.Where(x => x.IsDeleted == false);
        
        query = query.Where(x => x.Email == email);

        var user = await query.FirstOrDefaultAsync();
        
        if(user == null)
        {
            throw new KeyNotFoundException("User not found");
        }
        
        if(user.Password != password)
        {
            throw new UnauthorizedAccessException("UnAuthorize !");
        }
        
        // Claims đại diện cho các thông tin nằm trong payload của Jwt
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role),
            // Quan trọng: Claim này (new Claim(ClaimTypes.Role, user.Role),)
            // sẽ giúp mình phân quyền,
            new Claim("email", user.Email),
            new Claim("userId", user.Id.ToString()),
            new Claim("role", user.Role),
        };
        
        var token = JwtService.GenerateToken(claims, _jwtOptions);
        
        return token;
    }
}