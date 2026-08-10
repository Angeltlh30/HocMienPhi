using DOTNET_hocmienphi.repository.abtraction;
using DOTNET_hocmienphi.repository.enums;

namespace DOTNET_hocmienphi.repository.entity;

public class MentorFreetime : BaseEntity<Guid>
{
    public MentorFreetimeDateOfWeek DateOfWeek { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    
    public Guid MentorId { get; set; }
    public Mentor Mentor { get; set; }
    
    
}