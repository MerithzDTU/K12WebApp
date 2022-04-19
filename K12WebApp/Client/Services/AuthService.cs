using System.Net.Http.Json;

namespace K12WebApp.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;

        public AuthService(HttpClient httpClient)
        {
            _http = httpClient;
        }
        /* USER LOGIN */
        public async Task<HttpResponseMessage> LoginUser(UserLoginDto user)
        {
            var response = _http.PostAsJsonAsync<UserLoginDto>("api/auth/login", user);
            return await response;
        }

        /* USER REGISTRATION */
        public async Task<HttpResponseMessage> RegisterUser(UserRegisterDto user)
        {
            var response = _http.PostAsJsonAsync<UserRegisterDto>("api/auth/register", user);
            Console.WriteLine("REGISTER USER WITH RESPONSE: " + response);
            return await response;
        }

        /* USER EXISTENCE */
        public async Task<HttpResponseMessage> UserExists(UserLoginDto user)
        {
            var response = _http.PostAsJsonAsync<string>("api/auth/userexists", user.Email);
            return await response;
        }

        

    }
}
