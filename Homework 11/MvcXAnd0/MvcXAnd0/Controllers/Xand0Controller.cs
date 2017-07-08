using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcXAnd0.Models;
namespace MvcXAnd0.Controllers
{
    public class Xand0Controller : Controller
    {
        //
        // GET: /Xand0/

        public ActionResult Index()
        {
            GameModel model = new GameModel()
            {
                CurrentGame = new List<Coord>(),
                EditCoordonate = new Coord()
            };
            HttpContext.Session["game"] = model.CurrentGame;
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(GameModel x)
        {

            Coord inf = new Coord();
            Random rand = new Random();
            inf.CoordX = rand.Next(3);
            inf.CoordY = rand.Next(3);
            inf.Player = Player.O;
            x.CurrentGame = (List<Coord>)HttpContext.Session["game"];
            //if (x.CurrentGame == null)
            //{
            //    x.CurrentGame = new List<Coord>();
            //}
            x.CurrentGame.Add(inf);
            x.EditCoordonate.Player = Player.X;
            x.CurrentGame.Add(x.EditCoordonate);

            HttpContext.Session["game"] = x.CurrentGame;
            x.EditCoordonate = new Coord();
            //if (x.CurrentGame.Count > 0)
            //{
            //    if (x.CurrentGame.Exists(x => (x.CoordX == inf.CoordX) && (x.CoordY == inf.CoordY)))
            //        return false;
            //    x.EditCoordonate[inf.CoordX, inf.CoordY] = Player;
            //    x.CurrentGame.Add(x.EditCoordonate);
            //    return true;
            //}
            
            
            return View(x);
        }

    }
}
