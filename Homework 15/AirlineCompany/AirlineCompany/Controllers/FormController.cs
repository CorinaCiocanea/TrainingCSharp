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
        private AirlineEntities db = new AirlineEntities();
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Form form)
        {
           
                db.Forms.Add(form);
                db.SaveChanges();
                form.Message = "Successful completion";
                return RedirectToAction("Index");
            
            
            return View();
        
        }

        public ActionResult ViewSeat()
        {
            return View();
        }

    }
}
