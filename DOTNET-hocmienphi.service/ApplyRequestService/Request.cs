namespace DOTNET_hocmienphi.service.ApplyRequestService;

public class Request
{
    public class CreateApplyRequestRequest
    {
        public string Description { get; set; }
        public string CvLink{ get; set; }
        public Guid UserId { get; set; }
        public List<Guid> CategoryIds { get; set; } //Khi ng dung taạo don đki tro thanh mentor
                                                    //thi ho cung phải de cap toi nhung linh vuc ma ho Mentor
        
    } 
    public class ReviewApplyRequestRequest
    {
        public bool IsApproved { get; set; }
        public string? Reason { get; set; }
    }
}