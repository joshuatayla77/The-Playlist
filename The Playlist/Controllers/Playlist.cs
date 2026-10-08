using Microsoft.AspNetCore.Mvc;

namespace The_Playlist.Controllers
{
    public class Playlist : Controller
    {
        private string[] Songs = {
        "1.Justin Bieber - Baby","2.Ed Sheeran - Shape of You","3.Dua Lipa - Levitating","4.Ariana Grande - 7 Rings","5.The Weeknd - Blinding Lights" };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("liner-notes")]
        public IActionResult Notes()
        {
            return View();
        }
    }
}
