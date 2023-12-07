using CSCI213___Assignment_5.Data;
using CSCI213___Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSCI213___Assignment_5.Controllers {
    public class AdminController : Controller {
        public IActionResult Index() {
            return View();
        }

        private readonly CSCI213___Assignment_5Context dbcon;

        public AdminController(CSCI213___Assignment_5Context dbcon) { 
            this.dbcon = dbcon; 
        }

        [HttpPost]
        public IActionResult Add(Song song) {
            dbcon.Song.Add(song);
            dbcon.SaveChanges();
            return RedirectToAction("Index"); //Replace view
        }

        [HttpPost]
        public IActionResult Edit(Song song) {
            dbcon.Song.Update(song);
            dbcon.SaveChanges();
            return RedirectToAction("Index"); //Replace view
        }

        /*[HttpPost]
        public IActionResult Delete(Song song) { 
        }*/
    }
}
