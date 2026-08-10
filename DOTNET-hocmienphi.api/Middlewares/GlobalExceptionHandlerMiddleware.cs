using DOTNET_hocmienphi.service.Models;

namespace DOTNET_hocmienphi.api.Middlewares;

public class GlobalExceptionHandlerMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context); //-> Tạo ra 1 try catch, sau đó wait kết qua của Req trả ra    
                                //      Req lúc này vì bị next -> Req đi xuongs controller, service, repo
                                //      Vì await ở đay nên mình có thể nhận dc Response của Req 
                                // Response se có 2 case:
                                //      - Data bthg
                                //      - Data lỗi (Exception) - Catch nó
                                // Cần Global Exception vì nó hạn chế duplicate logic try-catch (có nhiều API thì cần vết mỗi cai 1 try-catch, KH CẦN -> sd global exception)
                                //                         minh kh thể cover het tất cả các Exception đc
                                //                          traánh bị crash app vì neu co 1 Exception mà ko đc catch -> app crash
        }
        catch (Exception ex)
        {
            var statusCode = MapStatusCode(ex);
            var errorMessage = GetErrorMessage(ex, statusCode);
            var detail = BuildErrorDetail(ex);
            //HttpContext context -> represent to request and response
            // neu muon độ lại status cua response thì tương tác với Context
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";
            
            var response = ResponseBuilder.ErrorResponse(null, errorMessage, context.TraceIdentifier);
            await context.Response.WriteAsJsonAsync(response);
        }
    }
    //Có đc Exception -> Need 2 things to response,
                        // Code: 400, 402, 500,..
                        // Message của Exception
    private static int MapStatusCode(Exception ex)
    {
        return ex switch
        {
            ArgumentException => StatusCodes.Status400BadRequest,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
    }
    
    private static string GetErrorMessage(Exception ex, int statusCode)
    {
        return statusCode >= 500 ? "Unexpected error occured" : ex.Message;
    }

    private static object? BuildErrorDetail(Exception ex)
    {
        return new
        {
            detail = ex.Message,
            exceptionType = ex.GetType().FullName,
            innerDetail = ex.InnerException?.Message,
            rootCauseDetail = ex.GetBaseException().Message,
        };
    }
}