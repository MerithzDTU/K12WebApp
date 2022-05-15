using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace K12WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _context.Users.Include(x => x.Role).ToListAsync();
            return Ok(users);
        }

        [HttpGet("roles")]
        public async Task<ActionResult<List<User>>> GetRoles()
        {
            var roles = await _context.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<User>> GetSingleUser(int id)
        {
            var user = await _context.Users
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound("Sorry no user found.");
            }
            return Ok(user);
        }
        [HttpGet]
        [Route("{id}/chores")]
        public async Task<ActionResult<List<ChoreMonth>>> GetUsersChores(int id)
        {
            var user = await _context.Users
                .Include(x => x.Role)
                .Include(x => x.UserChores)
                .ThenInclude(x => x.ChoreMonth)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound("Sorry no user found.");
            }
            List<ChoreMonth> choreMonths = user.UserChores.Where(x => x.AssignedRoomNo == user.RoomNo).Select(x => x.ChoreMonth).ToList();
            //var chores = await _context.UserChores.Where(u => u.AssignedRoomNo == user.RoomNo).ToListAsync();
            if (!choreMonths.Any())
                return NotFound("Sorry no chores found.");
            return Ok(choreMonths);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
            user.Role = null;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(User user, int id)
        {
            var dbUser = await _context.Users
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbUser == null)
                return NotFound("Sorry, but user could not be found.");

            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.NickName = user.NickName;
            dbUser.RoleId = user.RoleId;

            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var dbUser = await _context.Users
                .Include(x => x.Role)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbUser == null)
                return NotFound("Sorry, but user could not be found.");

            _context.Users.Remove(dbUser);
            await _context.SaveChangesAsync();

            return Ok(await GetDbUsers());
        }

        private async Task<List<User>> GetDbUsers()
        {
            return await _context.Users.Include(x => x.Role).ToListAsync();
        }
    }
}
