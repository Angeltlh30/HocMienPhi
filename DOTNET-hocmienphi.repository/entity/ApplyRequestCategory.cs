using DOTNET_hocmienphi.repository.abtraction;

namespace DOTNET_hocmienphi.repository.entity;

public class ApplyRequestCategory : BaseEntity<Guid>
{
    public Guid ApplyRequestId { get; set; }
    public ApplyRequest ApplyRequest { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}