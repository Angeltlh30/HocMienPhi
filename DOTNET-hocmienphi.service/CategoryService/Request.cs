namespace DOTNET_hocmienphi.service.CategoryService;

public class Request
{
    public class CreateCategoryRequest
    { 
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        //Guid?: optional -> vì sẽ có những category không có parent,
        //                  nên ParentId sẽ là optional (có thể null)
        //                  VD: những thằng dau tien
        
    }

    public class UpdateCategoryRequest : CreateCategoryRequest;
}