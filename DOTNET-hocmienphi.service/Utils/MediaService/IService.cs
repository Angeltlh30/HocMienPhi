using Microsoft.AspNetCore.Http;

namespace DOTNET_hocmienphi.service.MediaService;

public interface IService
{
    public Task<string> UploadImageAsync(IFormFile file);
    
}