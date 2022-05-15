using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace K12WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration, DataContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("userexists")]
        public async Task<ActionResult<bool>> UserExists(string email)
        {
            User? response = await _context.Users.SingleOrDefaultAsync(user => user.Email == email);
            if (response == null)
            {
                return BadRequest("User not found");
            }
            return Ok(true);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserLoginDto request)
        {
            User? dbUser = await _context.Users.FirstOrDefaultAsync(user => user.NickName == request.Username);
            var userExists = await _context.Users.AnyAsync(user => user.Email == request.Email);
           
            if (!userExists)
            {
                Console.WriteLine("BRUGEREN IKKE FUNDET");
                return BadRequest("Brugeren er ikke fundet.");
            }

            if (!VerifyPasswordHash(request.Password, dbUser?.PasswordHash, dbUser?.PasswordSalt))
            {
                return BadRequest("Forkert kodeord.");
            }

            string token = CreateToken(dbUser).Result;
            return Ok(token);
        }


        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserRegisterDto request)
        {
            var userExists = await _context.Users.AnyAsync(user => user.Email == request.Email);
            if (!userExists)
            {
                User user = new();
                user.RoleId = 3;
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Email = request.Email;
                user.NickName = request.NickName;
                CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.Users.Add(user);
                try
                {
                    Console.WriteLine("Adding user to db " + user);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return Ok(user);
            }
            else
            {
                return Conflict("User already exists!");
            }
        }

        private async Task<string> CreateToken(User user)
        {
            Role? userRole = await _context.Roles.FindAsync(user.RoleId);
            if (userRole == null)
            {
                throw new Exception("The user's role was not found.");
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.NickName),
                new Claim(ClaimTypes.Role, userRole.Name),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSetting:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                Console.WriteLine("COMPUTED HASH -----> " + computedHash.ToString() + "PASSWORDHASH -----> " + passwordHash.ToString());
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
