namespace K12WebApp.Client.Services
{
    public interface IAuthService
    {
        Task<HttpResponseMessage> RegisterUser(UserRegisterDto user);
        Task<HttpResponseMessage> LoginUser(UserLoginDto user);
        Task<HttpResponseMessage> UserExists(UserLoginDto user);
    }
}
