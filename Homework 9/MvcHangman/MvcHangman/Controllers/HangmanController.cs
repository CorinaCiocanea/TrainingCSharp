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
                    .Select(number => (char)number)
                    .ToArray()),
                letterNext = ' '
            };
            gameInfo.numberChoices = 2;
            gameInfo.lettersAvailable = new string(gameInfo.lettersAvailable.Where(element => gameInfo.letterUsed.Contains(element) == false).ToArray());

            return View(gameInfo);
        }

        [HttpPost]
        public ActionResult Index(GameInfo gameInfo)
        {
            gameInfo.numberChoices = 2;
          //  bool won = true;
            gameInfo.letterUsed += gameInfo.letterNext;
            foreach (var alfa in gameInfo.letterUsed)
            {
                if (gameInfo.hiddenWorld.Contains(Char.ToLower(alfa)) == false)
                {
                    gameInfo.numberChoices = gameInfo.numberChoices - 1;
                   
                }

                if (gameInfo.numberChoices == 0)
                {


                    return RedirectToAction("GameOver", "Hangman");
                    // won = false;
                }
                else
                {
                    
                    if (IsVictory3(gameInfo))
                    {
                        return RedirectToAction("Victory", "Hangman");
                    }
                
                }
                

            }
           

            gameInfo.letterNext = ' ';
            gameInfo.lettersAvailable = new string(Enumerable.Range(65, 26)
            .Select(number => (char)number)
            .Where(c => gameInfo.letterUsed.Contains(c) == false)
            .ToArray());

            ModelState.Clear();
            return View(gameInfo);
        }
        public ActionResult GameOver()
        {
            return View();
        }
        public ActionResult Victory()
        {
            return View();
        }
        private bool IsVictory1(GameInfo gameInfo)
        {
            int countLetters = 0;
            bool continueGame = false;
            foreach (char c in gameInfo.hiddenWorld)
            {
                if (gameInfo.letterUsed.Contains(Char.ToUpper(c)) == false)
                {
                    continueGame = true;
                    break;
                }
                else
                {
                    countLetters++;
                }
                //return continueGame == false;
            }
            return continueGame == false;
        }

        private bool IsVictory2(GameInfo gameInfo)
        {
            int countLetters = 0;
            foreach (char c in gameInfo.hiddenWorld)
            {
                if (gameInfo.letterUsed.Contains(Char.ToUpper(c)))
                {
                    countLetters++;
                }
                
            }
            return gameInfo.hiddenWorld.Length == countLetters;
        
        }

        private bool IsVictory3(GameInfo gameInfo)
        {
            int countLetters = 0;
            //bool continueGame = false;
            foreach (char c in gameInfo.letterUsed)
            {
                if (gameInfo.hiddenWorld.Contains(Char.ToUpper(c)))
                {
                    countLetters++;
                }

            }
            return gameInfo.letterUsed.Length == countLetters;

        }



        

    }

}

