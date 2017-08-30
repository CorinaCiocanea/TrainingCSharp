using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestaurant.Models
{
    public class BookingForm
    {
        public int BookingFormId { get; set; }
        public string NumberOfPeople { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime TimeOfBooking { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}