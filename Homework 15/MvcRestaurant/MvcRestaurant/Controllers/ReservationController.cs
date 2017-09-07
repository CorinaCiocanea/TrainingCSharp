using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models;
using System.Data.Entity;


namespace MvcRestaurant.Controllers
{
    public class ReservationController : Controller
    {
        private RestaurantEntities db = new RestaurantEntities();
        
        //
        // GET: /Reservation/

        public ActionResult Index()
        {
          
            return View();

        }
        [HttpPost]
        public ActionResult Index(BookingForm form)
        {
            bool tableExist = db.Tables.Any(table => table.Status.Equals(Status.Occupied));
            
            if (tableExist)
            {
                form.Message = "I'm sorry there is no free meal";
            }
            else
            {
                db.BookingForms.Add(form);
                db.SaveChanges();
                form.Message = "Successful completion";
                return RedirectToAction("Index");
            }
            return View(form);
        }
        public ActionResult ViewTables()
        {
            var listForm = db.Tables.ToList();
            //BookingForm form = db.BookingForms.Include(l => l.Tables).Single(l => l.BookingFormId == bookingId);
            //ViewBag.BookingFormId = new SelectList(db.BookingForms, "BookingFormId");
            return View(listForm);
        }
        public ActionResult ViewDiagram()
        {
            return View();
        }
    }
}
