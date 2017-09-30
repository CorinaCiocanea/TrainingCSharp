using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models;
using System.Data.Entity;
using MvcRestaurant.ViewModel;


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
                bool tableExist = db.Tables.Any(table => table.Status == Status.Free && table.BookingForms.All(a => a.ReservationDate != form.ReservationDate));

                if (!tableExist)
                {
                    form.Message = "I'm sorry there is no free meal";
                }
                else
                {
                    form.Message = "Successful completion";
                    
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
        public ActionResult ViewDiagram(BookingForm form)
        {
            BookingTable bookT = new BookingTable();
            bookT.TablesView = new List<TableView>();
            var myTables = db.Tables.Include(b => b.BookingForms).ToList();
            foreach (Table table in myTables)
            {
                bool reservation = table.BookingForms.Any(b => b.ReservationDate == form.ReservationDate);
                var tableView = new TableView()
                {
                    CoordinatesTable = table.CoordinatesTable,
                    TableId = table.TableId,
                    DimensionTable = table.DimensionTable,
                    //Status = table.BookingForms.Any(b => b.ReservationDate == form.ReservationDate),
                };
                if (reservation == true)
                {
                    tableView.Status = Status.Reserved;
                }
                else
                {
                    tableView.Status = Status.Free;
                }

               // bookT.TablesView = new List<TableView>();
                bookT.TablesView.Add(tableView);
            }
            bookT.BookingFormView = new List<BookingForm>();
            return View(bookT);
        }
        public bool AnswerTime(BookingForm book)
        {
            return book.ReservationDate == DateTime.Now;
        }
        public ActionResult ConfirmReservation(BookingTable bConfirm)
        {
            var tableForm = db.Tables.Include(b => b.BookingForms);
            
           // db.BookingForms.Add(bConfirm);
          //  db.SaveChanges();
            return View();
        }
    }
}
