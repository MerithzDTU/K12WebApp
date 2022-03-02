using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace K12WebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        public static List<Grocery> groceries = new List<Grocery>
        {
           new Grocery{ Id = 1, GroceryName = "Løg", DateCreated = DateTime.Now, isBought = false },
           new Grocery{ Id = 1, GroceryName = "Hvidløg", DateCreated = DateTime.Now, isBought = false }
        };
    }
}
