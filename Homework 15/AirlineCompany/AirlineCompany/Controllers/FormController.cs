using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirlineCompany.Models;

namespace AirlineCompany.Controllers
{
    public class FormController : Controller
    {
        private Form fr = new Form();
        //
        // GET: /Form/

        public ActionResult Index()
        {
            
            return View();
        }

    }
}
