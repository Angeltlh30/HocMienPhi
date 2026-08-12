using DOTNET_hocmienphi.repository.abtraction;

namespace DOTNET_hocmienphi.repository.entity
{
    public class User : BaseEntity<Guid>
    // Khi ke thua cha (class hoặc abs class) luon nằm đầu tiên sau dau ":"
    // Những thg nằm sau thg cha thì là interface
    // Tại sao dotNET kh có đa kế thừa: 
    // Bài toán diamond problem (viblo)
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string? Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } //admin, mentor, student
        public string Phone { get; set; }
        public DateOnly SendDate { get; set; }
        
        //MQH 1-1
        public Mentor? Mentor { get; set; }
        
        public ICollection<ApplyRequest> ApplyRequests { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
    
    
}