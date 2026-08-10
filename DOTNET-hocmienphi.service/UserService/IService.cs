namespace DOTNET_hocmienphi.service.UserService;

public interface IService
{
    public Task<List<Response.GetUserResponse>> GetAllUser(string? searchTerm, int pageIndex, int pageSize);
    public Task<string> CreateUser(Request.CreateUserRequest requestBody);
    public Task<string> UpdateUserById(Guid id, Request.UpdateUserRequest requestBody);
    public Task<string> Login(string email, string password);
}