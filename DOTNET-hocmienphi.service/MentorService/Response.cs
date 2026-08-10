namespace DOTNET_hocmienphi.service.MentorService;

public class Response
{
    public class MentorResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? OrganizationName { get; set; }
        public string? CurrentPosition { get; set; }
        public List<CategoryService.Response.GetAllParentCategoryResponse> Categories { get; set; }
    }
}