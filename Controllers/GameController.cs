using KPL_MOD10_SE_48_02_103022400016_ENH.Models;
using Microsoft.AspNetCore.Mvc;

namespace TP_MODUL10_103022400016.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Games> games = new List<Games>
        {
            new Games { Nama = "Valorant", Developer = "Riot Games", Tahun = 2020, Genre = "FPS", Rating = 8.5, Platform = ["PC"], Mode = ["Multiplayer"], IsOnline = true, Harga = 0 },
            new Games { Nama = "GTA V", Developer = "Rockstar Games", Tahun = 2013, Genre = "Open World", Rating = 9.5, Platform = ["PC", "PS4", "PS5", "Xbox"], Mode = ["Singleplayer", "Multiplayer"], IsOnline = true, Harga = 300000 },
            new Games { Nama = "The Witcher 3", Developer = "CD Projekt Red", Tahun = 2015, Genre = "RPG", Rating = 9.7, Platform = ["PC", "PS4", "PS5", "Xbox", "Switch"], Mode = ["Singleplayer"], IsOnline = false, Harga = 250000 }
        };

        [HttpGet]
        public ActionResult<List<Games>> GetAll()
        {
            return games;
        }

        [HttpGet("{index}")]
        public ActionResult<Games> GetByIndex(int index)
        {
            if (index < 0 || index >= games.Count)
                return NotFound();

            return games[index];
        }

        [HttpPost]
        public ActionResult AddFilm([FromBody] Games film)
        {
            games.Add(film);
            return Ok(games);
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteFilm(int index)
        {
            if (index < 0 || index >= games.Count)
                return NotFound();

            games.RemoveAt(index);
            return Ok(games);
        }
    }
}