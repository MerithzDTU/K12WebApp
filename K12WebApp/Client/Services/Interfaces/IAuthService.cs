using System.IdentityModel.Tokens.Jwt;

namespace K12WebApp.Client.Services
{
    public interface IAuthService
    {
        Task<int> GetCurrentUserId();
        Task<string> GetCurrentUserRole();
        Task<bool> UserHasPermissions();
        Task<JwtSecurityToken> GetCurrentToken();
        Task<HttpResponseMessage> RegisterUser(UserRegisterDto user);
        Task<HttpResponseMessage> LoginUser(UserLoginDto user);
        Task<HttpResponseMessage> UserExists(UserLoginDto user);
    }
}
