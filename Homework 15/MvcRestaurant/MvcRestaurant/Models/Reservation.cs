using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestaurant.Models
{
    public class Reservation
    {
        public Reservation()
        {
            Tables = new List<Table>();
        }
        public int BookingFormId { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime? ReservationDate { get; set; }
        public DateTime? ReservationTime { get; set; }
        public string Message { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}