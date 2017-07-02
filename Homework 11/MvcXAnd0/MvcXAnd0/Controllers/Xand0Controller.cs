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
            return View();
        }
        [HttpPost]
        public ActionResult Index()
        {

            Coord inf = new Coord();
            Random rand = new Random();
            inf.CoordX = inf.Row;
            inf.CoordY = inf.Column;
            inf.Row = rand.Next();

            Player currentPlayer = Player.X;
            if (currentPlayer == Player.X)
            {
                currentPlayer = Player.O;
            }
            else
                if (currentPlayer == Player.O)
                {
                    currentPlayer = Player.X;
                    
                }
            return View();
        }

    }
}
