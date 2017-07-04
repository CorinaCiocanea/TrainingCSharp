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
            return View(new List<MvcXAnd0.Models.Coord>());
        }
        [HttpPost]
        public ActionResult Index(Coord model)
        {

            Coord inf = new Coord();
            Random rand = new Random();
            inf.CoordX = rand.Next(3);
            inf.CoordY = rand.Next(3);
            inf.Player = Player.O;
            inf.Row = rand.Next();

            int nrmove = 0;
            bool winner = false;

            while (!winner && nrmove < 9)
            {
               
            
            }
            //Player currentPlayer = Player.X;
            //if (currentPlayer == Player.X)
            //{
            //    currentPlayer = Player.O;
            //}
            //else
            //    if (currentPlayer == Player.O)
            //    {
            //        currentPlayer = Player.X;
                    
            //    }
             model.Player = Player.X;
             var game = new List<MvcXAnd0.Models.Coord>();
             game.Add(model);
            game.Add(inf);
            return View(model);
        }

    }
}
