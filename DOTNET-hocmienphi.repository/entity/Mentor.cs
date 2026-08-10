using DOTNET_hocmienphi.repository.abtraction;

namespace DOTNET_hocmienphi.repository.entity;

public class Mentor : BaseEntity<Guid>
{
    //có the null vì user mới move thành mentor thì vẫn null
    //mentor login lần đầu thì set lại
    public string? OrganizationName { get; set; } //Fpt software
    public string? CurrentPosition { get; set; } //Senior Software Engineer
    
    public User? User { get; set; }
    public Guid UserId { get; set; }
    
    public ICollection<MentorCategory> MentorCategories { get; set; }
    public ICollection<Booking> Bookings { get; set; }
    public ICollection<MentorFreetime> MentorFreetimes { get; set; }
}