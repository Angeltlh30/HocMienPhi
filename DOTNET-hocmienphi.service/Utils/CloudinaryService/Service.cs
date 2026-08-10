using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DOTNET_hocmienphi.service.Utils.CloudinaryService;

public class Service : MediaService.IService
{   
    private readonly Cloudinary _cloudinary;
    private readonly CloudinaryOptions _cloudinaryOptions =  new();
    public Service(IConfiguration configuration)
    {
        configuration.GetSection(nameof(CloudinaryOptions)).Bind(_cloudinaryOptions);
        _cloudinary = new Cloudinary(new Account(_cloudinaryOptions.CloudName, _cloudinaryOptions.ApiKey, _cloudinaryOptions.ApiSecret));
    }
    public async Task<string> UploadImageAsync(IFormFile file)
    {
        //cách lấy ra từ appsetting -> Binding
        if (file.Length == 0 || file == null) throw new Exception("File not exist");
        if(!IsImageFile(file)) throw new Exception("File not exist");
        if(!IsValidImageLength(file)) throw new Exception("File invalid");
        //Upload lên cloudinary
        await using var stream = file.OpenReadStream();
        var uploadPrams = new ImageUploadParams()
        {
            File = new FileDescription(file.FileName, stream)
        };
        var uploadResult = await _cloudinary.UploadAsync(uploadPrams);
        return uploadResult.SecureUri.ToString();

    }
    
    private bool IsValidImageLength(IFormFile file)
    {
        const int maxMegaBytes = 5; //max 5MB
        long maxBytes = maxMegaBytes * 1024 * 1024; //->Byte
        if (file.Length > maxMegaBytes) return false;
        return true;
    }
    
    private bool IsImageFile(IFormFile file)
    {
        var allowedExtensions = new string[]
        {
            ".jpg",
            ".jpeg",
            ".png",
            ".gif",
            ".webp"
        };
        var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
        
        return allowedExtensions.Contains(fileExtension);
    }
}