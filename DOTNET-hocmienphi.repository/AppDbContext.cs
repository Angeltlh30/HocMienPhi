using DOTNET_hocmienphi.repository.entity;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_hocmienphi.repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User>  Users { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Mentor>  Mentors { get; set; }
        public DbSet<MentorCategory>  MentorCategories { get; set; }
        public DbSet<ApplyRequest>  ApplyRequests { get; set; }
        public DbSet<Booking>  Bookings { get; set; }
        public DbSet<MentorFreetime>  MentorFreetimes { get; set; }
        public DbSet<ApplyRequestCategory>  ApplyRequestCategories { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                //bắt đầu config sâu
                builder
                    .Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(255);
                
                //Ky thuat Indexing
                builder 
                    .HasIndex(u => u.Email)
                    .IsUnique();
                
                builder.Property(u => u.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);
                
                builder.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
                
                //Với mooxi User thi co nhieu meetings,
                //1 meeting thì có 1 user
                
                builder
                    .HasOne(u => u.Mentor)
                    .WithOne(m => m.User)
                    .HasForeignKey<Mentor>(m => m.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                builder
                    .HasMany(u => u.ApplyRequests)
                    .WithOne(m => m.User)
                    .HasForeignKey(m => m.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                builder
                    .HasMany(u => u.Bookings)
                    .WithOne(m => m.User)
                    .HasForeignKey(m => m.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                //Khi mà chỉ định việc khai báo các mqh ở đay
                    //các mqh sẽ kh bg bị tạo thiếu
                //Minh co the config các behavior (hành động)
                    //khi có sự thay đổi dữ ệu giữa các mqh
                    
                //VD: 1 User có nhiu Meetings -> khi user bị xóa đi
                //OnDelete sẽ xử lý
                // DeleteBehavior.Cascade: Khi một User bị xóa, thì Meetings liên quan cũng sẽ bị xóa theo.
                // DeleteBehavior.Restrict: Ngăn chặn việc xóa một User nếu có Meetings liên quan tồn tại.
                // (Tham chiếu tới PK tồn tại)
                // 1 Project còn Task thì không xóa được

                // DeleteBehavior.NoAction: Không thực hiện hành động gì đặc biệt khi User bị xóa.
                // (Gần giống Restrict, xử lí ở DB)

                // DeleteBehavior.SetNull: Khi một User bị xóa, thì trường UserId trong bảng Meetings sẽ được đặt thành NULL..
                // (Áp dụng khi trường FK cho phép NULL)
                
                //Kh cần config thêm bảng còn lại
                
                //SEED DATA
                /*
                 *new User()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "hoan@gmail.com",
                        Password = "123123",
                        Phone = "123123",
                        Role = "Student",
                        Age = "10",
                        IsDeleted = false
                    },
                    new User()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Jane",
                        LastName = "Doe",
                        Email = "hoanhah@gmail.com",
                        Password = "123123",
                        Phone = "123123",
                        Role = "Student",
                        Age = "10",
                        IsDeleted = false
                    }
                 * 
                 */
                
                List<User> list = new List<User>()
                {
                    
                };
                for (int i = 0; i < 100; i++)
                {
                    var newUser = new User()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "FirstName" + i,
                        LastName = "LastName" + i,
                        Email = "Email" + i + "@gmail.com",
                        Password = "123123",
                        Phone = "123123",
                        Role = "Student",
                        Age = "10",
                        IsDeleted = false,
                    };
                    list.Add(newUser);
                }
                builder.HasData(list);
            });
            
            modelBuilder.Entity<Mentor>(builder =>
            {
                builder.HasMany(u => u.MentorCategories)
                    .WithOne(m => m.Mentor)
                    .HasForeignKey(m => m.MentorId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                builder
                    .HasMany(u => u.Bookings)
                    .WithOne(m => m.Mentor)
                    .HasForeignKey(m => m.MentorId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                builder
                    .HasMany(u => u.MentorFreetimes)
                    .WithOne(m => m.Mentor)
                    .HasForeignKey(m => m.MentorId)
                    .OnDelete(DeleteBehavior.Cascade);

            });
            
            modelBuilder.Entity<Category>(builder =>
            {
                builder
                    .HasMany(u => u.MentorCategories)
                    .WithOne(m => m.Category)
                    .HasForeignKey(m => m.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
                
                builder
                    .HasMany(u => u.ApplyRequestCategories)
                    .WithOne(m => m.Category)
                    .HasForeignKey(m => m.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            
            modelBuilder.Entity<ApplyRequest>(builder =>
            {
                builder
                    .HasMany(u => u.ApplyRequestCategories)
                    .WithOne(m => m.ApplyRequest)
                    .HasForeignKey(m => m.ApplyRequestId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            
        }
        //3 step to create new table:
            //3 layers system program
            //Access repository -> entity -> create new category class
            //Declare fields: id, name
            //Declare fields reference to relationship (ParentID, Parent...)
            ////Declare into DBContext
            //Run migration to create file migration (version of DB)
            //Update DB -> Refresh public/tables
    }
}