using DOTNET_hocmienphi.repository.enums;

namespace DOTNET_hocmienphi.service.ApplyRequestService;

public class Response
{
    public class GetApplyRequestResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CvLink { get; set; }
        public ApplyRequestStatus Status { get; set; }
        public string? RejectReason { get; set; }
            
        public UserService.Response.GetUserResponse User { get; set; }
        public List<CategoryService.Response.GetAllParentCategoryResponse> Categories { get; set; }
    }
}