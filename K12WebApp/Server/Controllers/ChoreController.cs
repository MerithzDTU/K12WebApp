using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace K12WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoreController : ControllerBase
    {
        private readonly DataContext _context;
        public ChoreController(DataContext context)
        {
              _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Chore>>> GetChores()
        {
            var chores = await _context.Chores.Include(x => x.ChoreMonths).ToListAsync();
            return Ok(chores);
        }

        [HttpGet("choremonths")]
        public async Task<ActionResult<List<ChoreMonth>>> GetChoreMonths()
        {
            var choreMonths = await _context.ChoreMonths.ToListAsync();
            return Ok(choreMonths);
        }
        [HttpGet("userchores")]
        public async Task<ActionResult<List<UserChore>>> GetUserChores()
        {
            var choreMonthUsers = await _context.UserChores.ToListAsync();
            return Ok(choreMonthUsers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Chore>> GetSingleChore(int id)
        {
            var chore = await _context.Chores
                .Include(x => x.ChoreMonths)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (chore == null)
            {
                return NotFound("Sorry no chore found.");
            }
            return Ok(chore);
        }

        [HttpPost]
        public async Task<ActionResult<List<Chore>>> CreateChore(Chore chore)
        {
            await CreateChoreMonths(chore);
            _context.Chores.Add(chore);
            await _context.SaveChangesAsync();

            return Ok(await GetDbChores());
        }

        [HttpPost("createchoremonths")]
        public async Task<ActionResult<List<ChoreMonth>>> CreateChoreMonths(Chore chore)
        {
            List<ChoreMonth> newChoreMonths = new List<ChoreMonth>();
            newChoreMonths.AddRange(new List<ChoreMonth>
            {
                    new ChoreMonth { ChoreId = chore.Id, Name = "januar" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "februar" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "marts" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "april" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "maj" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "juni" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "juli" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "august" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "september" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "october" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "november" },
                    new ChoreMonth { ChoreId = chore.Id, Name = "december" },
            });
            _context.Add(newChoreMonths);
            await _context.SaveChangesAsync();
            return Ok(await GetDbChores());

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateChore(Chore chore, int id)
        {
            var dbChore = await _context.Chores
                .Include(x => x.ChoreMonths)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbChore == null)
                return NotFound("Sorry, but chore could not be found.");

            dbChore.Name = chore.Name;
            dbChore.Description = chore.Description;

            await _context.SaveChangesAsync();

            return Ok(await GetDbChores());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var dbChore = await _context.Chores
                .Include(x => x.ChoreMonths)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbChore == null)
                return NotFound("Sorry, but chore could not be found.");

            _context.Chores.Remove(dbChore);
            await _context.SaveChangesAsync();

            return Ok(await GetDbChores());
        }

        private async Task<List<Chore>> GetDbChores()
        {
            return await _context.Chores.Include(x => x.ChoreMonths).ToListAsync();
        }

    }
}

