namespace DOTNET_hocmienphi.service.UserService;

public class Response
{
    public class GetUserResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
    }
}