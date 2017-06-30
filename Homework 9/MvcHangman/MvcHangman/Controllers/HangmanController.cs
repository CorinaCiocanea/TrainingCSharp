using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcHangman.Models;

namespace MvcHangman.Controllers
{
    public class HangmanController : Controller
    {
        private List<string> worlds;
        public HangmanController()
        {
            worlds = new List<string>() { "scoala", "masina", "avion", "carte", "barca", "bicicleta" };
        }
        //
        // GET: /Hangman/

        public ActionResult Index()
        {


            Random random = new Random();
            int index = random.Next(worlds.Count - 1);
            GameInfo gameInfo = new GameInfo()
            {
                hiddenWorld = worlds[index],
                letterUsed = "A",
                lettersAvailable = new string(Enumerable.Range(65, 26)
                    .Select(number => (char) number)
                    .ToArray()),
                letterNext = ' '
            };
            gameInfo.numberChoices = 4;
            gameInfo.lettersAvailable = new string(gameInfo.lettersAvailable.Where(element => gameInfo.letterUsed.Contains(element) == false).ToArray());
            
            return View(gameInfo);
        }
             
    [HttpPost]
        public ActionResult Index(GameInfo gameInfo)
            {
                gameInfo.numberChoices = 4;
                gameInfo.letterUsed += gameInfo.letterNext;
                gameInfo.letterNext = ' ';
                   gameInfo.lettersAvailable = new string(Enumerable.Range(65, 26)
                   .Select(number => (char)number)
                   .Where(c => gameInfo.letterUsed.Contains(c) == false)
                   .ToArray());
             
                ModelState.Clear();
                return View(gameInfo);
            }
    }

}

