using Microsoft.AspNetCore.Mvc;

namespace CSCI213___Assignment_5.Controllers {
    public class AdminController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
