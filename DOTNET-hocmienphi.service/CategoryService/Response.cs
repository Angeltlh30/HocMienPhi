using DOTNET_hocmienphi.repository.entity;

namespace DOTNET_hocmienphi.service.CategoryService;

public class Response
{
    public class GetAllParentCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}