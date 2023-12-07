using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CSCI213___Assignment_5.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Artists(string genre)
        {
            ViewData["Genre"] = genre;
            ViewData["Artists"] = GetArtistsByGenre(genre);

            return View();
        }

        // Sample data representing artists for different genres
        private List<string> GetArtistsByGenre(string genre)
        {
            List<string> artists = new List<string>();

            switch (genre.ToLower())
            {
                case "rock":
                    artists = new List<string> { "Artist 1", "Artist 2", "Artist 3" };
                    break;
                case "pop":
                    artists = new List<string> { "Artist A", "Artist B", "Artist C" };
                    break;
                case "80s":
                    artists = new List<string> { "80s Artist X", "80s Artist Y", "80s Artist Z" };
                    break;
                case "country":
                    artists = new List<string> { "Country Artist I", "Country Artist II", "Country Artist III" };
                    break;
                default:
                    break;
            }

            return artists;
        }
    }
}
