using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace K12WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        private readonly DataContext _context;

        public GroceryController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Grocery>>> GetGroceries()
        {
            var groceries = await _context.Groceries.Include(x => x.CreatedByUser).ToListAsync();
            return Ok(groceries);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Grocery>> GetSingleGrocery(int id)
        {
            var grocery = await _context.Groceries
                .Include(x => x.CreatedByUser)
                .FirstOrDefaultAsync(x => x.Id == id);
            if(grocery == null)
            {
                return NotFound("Sorry no grocery was found.");
            }
            return Ok(grocery);
        }

        [HttpPost]
        public async Task<ActionResult<List<Grocery>>> CreateGrocery(Grocery grocery)
        {
            grocery.DateCreated = DateTime.Now;
            _context.Groceries.Add(grocery);
            await _context.SaveChangesAsync();

            return Ok(await GetDbGroceries());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Grocery>>> UpdateGrocery(Grocery grocery, int id)
        {
            var dbGrocery = await _context.Groceries
                .Include(x => x.CreatedByUser)
                .FirstOrDefaultAsync(x => x.Id == id);
            if(dbGrocery == null)
                return NotFound("Sorry, but the grocery could not be found.");

            dbGrocery.GroceryName = grocery.GroceryName;
            dbGrocery.isBought = grocery.isBought;
            dbGrocery.LastUpdated = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(await GetDbGroceries());
            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Grocery>>> DeleteGrocery(int id)
        {
            var dbGrocery = await _context.Groceries.FirstOrDefaultAsync(x => x.Id == id);
            if (dbGrocery == null)
            {
                return NotFound("Sorry, but the grocery couldn't be found.");
            }

            _context.Groceries.Remove(dbGrocery);
            await _context.SaveChangesAsync();

            return Ok(await GetDbGroceries());
        }

        private async Task<List<Grocery>> GetDbGroceries()
        {
            return await _context.Groceries.Include(x => x.CreatedByUser).ToListAsync();
        }
    }
}
