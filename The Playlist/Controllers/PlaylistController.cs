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

          
            ViewData["Tunes"] = $"#{number}: {Songs[number - 1]}";
            ViewBag.Number = number;


            return View();
            //}}
        }
            [HttpGet("Find/{**anything}")]
            public IActionResult FindAll(
            string anything)
        {
            ViewData["Asked"] = anything;
            return View();
        }
        [HttpGet("find/{word:alpha}")]
        public IActionResult Find(string word)
        {
            string[] Songs = {
            "Justin Bieber - Baby",
                "Ed Sheeran - Shape of You",
                "Dua Lipa - Levitating",
                "Ariana Grande - 7 Rings",
                "The Weeknd - Blinding Lights"
            };
            int foundIndex = -1;
            for (int i = 0; i < Songs.Length; i++)
            {
                if (Songs[i].Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    foundIndex = i;
                    break;
                }
            }
            ViewData["Word"] = word;
            if (foundIndex != -1)
            {
                ViewData["Number"] = foundIndex + 1;
                ViewData["Tunes"] = Songs[foundIndex];
                return View("Find");
            }
            return View("FindNothing");
        }


    }
    }
