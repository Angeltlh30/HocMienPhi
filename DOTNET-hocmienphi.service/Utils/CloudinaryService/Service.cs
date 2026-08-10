using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DOTNET_hocmienphi.service.CloudinaryService;
using MediaService;

public class Service : MediaService.IService
{
    private readonly CloudinaryOptions _cloudinaryOptions =  new();
    public Service(IConfiguration configuration)
    {
        configuration.GetSection(nameof(CloudinaryOptions)).Bind(_cloudinaryOptions);
    }
    public Task<string> UploadImageAsync(IFormFile file)
    {
        //cách lấy ra từ appsetting -> Binding
        
    }
}