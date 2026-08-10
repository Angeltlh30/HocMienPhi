using DOTNET_hocmienphi.repository.abtraction;

namespace DOTNET_hocmienphi.repository.entity;

public class Category : BaseEntity<Guid>
{
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public Category? Parent { get; set; } //null được

    //thể hiện mqh 1-n
    public ICollection<Category> Children { get; set; } //mảng, array, list
    //Nhờ khai báo ParentID và Parent thì EF sẽ tự động hiểu đây là mqh cha con,
    //và sẽ tạo ra 1 FK trong db liên kết giữa 2 table Category với nhau
    //Nhờ vi khai bao ICollection ma EF hiểu đây là mqh 1-n
    
    public ICollection<MentorCategory> MentorCategories { get; set; }
    public ICollection<ApplyRequestCategory> ApplyRequestCategories { get; set; }
}