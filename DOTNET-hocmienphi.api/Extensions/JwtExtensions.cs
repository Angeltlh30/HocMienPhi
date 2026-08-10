using System.Security.Claims;
using System.Text;
using DOTNET_hocmienphi.service.Utils.JWTService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace DOTNET_hocmienphi.api.Extensions;

public static class JwtExtensions
{
    public const string AdminPolicy = nameof(AdminPolicy);
    public const string MentorPolicy = nameof(MentorPolicy);
    public const string AdminAndMentorPolicy = nameof(AdminAndMentorPolicy);
    public static void AddJwtServices(this IServiceCollection services, IConfiguration configuration)
    {
        JwtOptions jwtOption = new JwtOptions();
        configuration.GetSection(nameof(JwtOptions)).Bind(jwtOption);
        var key = Encoding.UTF8.GetBytes(jwtOption.SecretKey);
        
        //Máy móc  thì kh xử lý string như cta, tùy thư viện
        // đối vơới thư vện nay thì nó tương tác với manng
        services
            .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtOption.Issuer,
                    ValidAudience = jwtOption.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    NameClaimType = ClaimTypes.NameIdentifier,
                    RoleClaimType = ClaimTypes.Role
                };
            });
        services.AddAuthorization(options =>
        {
            options.AddPolicy(AdminPolicy, 
                policy => policy.RequireRole("Admin"));
            options.AddPolicy(MentorPolicy, 
                policy => policy.RequireRole("Mentor"));
            options.AddPolicy(AdminAndMentorPolicy, 
                policy => policy.RequireRole("Admin", "Mentor"));
        });
    }
}