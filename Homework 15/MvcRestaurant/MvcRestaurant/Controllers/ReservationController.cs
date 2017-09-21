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

            ViewBag.BookingFormId = new SelectList(db.BookingForms, "BookingFormId");
            return View();

        }
        [HttpPost]
        public ActionResult Index(BookingForm form)
        {
            if (ModelState.IsValid)
            {
                bool tableExist = db.Tables.Any(table => table.Status == Status.Free && table.Tables.All(a => a.ReservationDate != form.ReservationDate));

                if (!tableExist)
                {
                    form.Message = "I'm sorry there is no free meal";
                }
                else
                {
                    db.BookingForms.Add(form);
                    db.SaveChanges();
                    form.Message = "Successful completion";
                    return RedirectToAction("ViewDiagram");
                }
            }
            ViewBag.BookingFormId = new SelectList(db.BookingForms, "BookingFormId");
            return View(form);
        }
        public ActionResult ViewTables()
        {
            var listForm = db.Tables.ToList();
            return View(listForm);
        }
        public ActionResult ViewDiagram()
        {
            //var listForm = db.BookingForms.ToList();

            var listForm = db.Tables.ToList();
            return View(listForm);
        }
    }
}
