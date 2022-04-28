using System.Net.Http.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace K12WebApp.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _http = httpClient;
            _localStorage = localStorage;

        }

        public async Task<JwtSecurityToken> GetCurrentToken()
        {
            var token = await _localStorage.GetItemAsync<string>("token");
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            Console.WriteLine("JSON TOKEN : " + jsonToken);
            return (JwtSecurityToken)jsonToken;
            
        }                                                    

        public async Task<int> GetCurrentUserId()
        {
            var tokenS = await GetCurrentToken();
            var nameClaim = tokenS.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault();
            if (nameClaim != null)
            {
                int userId = int.Parse(nameClaim.Value);
                return userId;
            }
            else
            {
                return 0;
            }
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
