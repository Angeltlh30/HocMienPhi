using Microsoft.AspNetCore.Http;

namespace DOTNET_hocmienphi.service.Utils.MediaService;

public interface IService
{
    public Task<string> UploadImageAsync(IFormFile file);
    
}