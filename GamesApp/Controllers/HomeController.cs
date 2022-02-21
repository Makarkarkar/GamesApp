using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GamesApp.Controllers
{
    public class HomeController: Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        // GET: /
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        // GET: Home/Privacy
        [HttpGet]
        
        public IActionResult Games()
        {
            
            return View();
        }
        public IActionResult Genres()
        {
            
            return View();
        }

        
        
    }
}