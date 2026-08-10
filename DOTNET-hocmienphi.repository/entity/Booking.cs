using DOTNET_hocmienphi.repository.abtraction;

namespace DOTNET_hocmienphi.repository.entity;

public class Booking : BaseEntity<Guid>
{
    public DateTimeOffset StarTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }
    
    public Guid MentorId { get; set; }
    public Mentor Mentor { get; set; }
}