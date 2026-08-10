namespace DOTNET_hocmienphi.service.Models;

public class ApiResponse
{
    public bool IsSuccess { get; set; }
    public required string Message { get; set; } // Login thanh cong | Login that bai
    public object? Data { get; set; }
    public object? Errors { get; set; }
    public string? TraceId { get; set; }
    // Moi request se duoc dinh danh 1 traceId
    // TraceId dung de phan biet cac request voi nhau
    public DateTime TimestampUtc { get; set; }
}

public static class ResponseBuilder
{
    public static ApiResponse SuccessResponse(object? data, string message, string? traceId = null)
    {
        return new ApiResponse()
        {
            IsSuccess = true,
            Message = message,
            Data = data,
            TraceId = traceId,
            TimestampUtc = DateTime.UtcNow
        };
    }
    
    public static ApiResponse ErrorResponse(object? errors , string message, string? traceId = null)
    {
        return new ApiResponse()
        {
            IsSuccess = false,
            Message = message,
            Errors = errors,
            TraceId = traceId,
            TimestampUtc = DateTime.UtcNow
        };
    }
}