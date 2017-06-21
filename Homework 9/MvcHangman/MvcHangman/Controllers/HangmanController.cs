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
        //
        // GET: /Hangman/

        public ActionResult Index()
        {
            return View();
        }

    }
}
