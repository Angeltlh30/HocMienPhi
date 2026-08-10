using Microsoft.AspNetCore.Http;

namespace DOTNET_hocmienphi.service.UserService;

public class Request
{
    public class CreateUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UpdateUserRequest : CreateUserRequest
    {
        public IFormFile? Avatar { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
    }
}