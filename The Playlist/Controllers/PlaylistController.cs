using Microsoft.AspNetCore.Mvc;

namespace The_Playlist.Controllers
{
    public class PlaylistController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("liner-notes")]
        public IActionResult Notes()
        {
            return View();
        }
        [HttpGet("track/{number=1}")]
        public IActionResult Track(int number)
        {
        string[] Songs = {
            "Justin Bieber - Baby",
                "Ed Sheeran - Shape of You",
                "Dua Lipa - Levitating",
                "Ariana Grande - 7 Rings",
                "The Weeknd - Blinding Lights" 
            };

            //if (number < 1 || number > Songs.Length)
            //{
            //    return NotFound();
            //}
            //else
            //{
                ViewData["Tunes"] = $"#{number}: {Songs[number - 1]}";
                return View();
            //}

        }
    }
}