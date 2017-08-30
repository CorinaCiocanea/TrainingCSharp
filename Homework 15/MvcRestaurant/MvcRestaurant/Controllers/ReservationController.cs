using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models;
using System.Data.Entity;
using System.Web;

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
        public ActionResult ViewTables()
        {
            var listForm = db.Tables.ToList();
            //BookingForm form = db.BookingForms.Include(l => l.Tables).Single(l => l.BookingFormId == bookingId);
            //ViewBag.BookingFormId = new SelectList(db.BookingForms, "BookingFormId");
            return View(listForm);
        }
    }
}
