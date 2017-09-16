using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestaurant.Models
{
    public class BookingForm
    {
        public BookingForm()
        {
            Tables = new List<Table>();
        }
        public int BookingFormId { get; set; }
        public string NumberOfPeople { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime TimeOfBooking { get; set; }
        public string Message { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}