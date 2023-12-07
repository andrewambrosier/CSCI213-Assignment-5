using CSCI213___Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSCI213___Assignment_5.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }
        public IActionResult BrowseMusic()
        {
            return View();  
        }
        public IActionResult Artists()
        {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}