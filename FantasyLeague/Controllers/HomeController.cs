using Microsoft.AspNetCore.Mvc;

namespace FantasyLeague.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok("Fantasy league service running.");
        }
    }
}