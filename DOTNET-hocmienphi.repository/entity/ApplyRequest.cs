using DOTNET_hocmienphi.repository.abtraction;
using DOTNET_hocmienphi.repository.enums;

namespace DOTNET_hocmienphi.repository.entity;

public class ApplyRequest : BaseEntity<Guid>
{
    public string Description { get; set; }
    public string CvLink { get; set; }
    //Họ dua minh file CV, sau do minh upload len Cloud
    
    //Pending, Approved, Rejected
    public ApplyRequestStatus Status { get; set; } = ApplyRequestStatus.Pending;
    public string? RejectReason { get; set; }
   
    public Guid UserId { get; set; }
    public User User { get; set; }
    
    public ICollection<ApplyRequestCategory> ApplyRequestCategories { get; set; }
}