using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineCompany
{
    public enum Day {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    
    }
    class Flight
    {
        private string location;
        private string destination;
        private int flightduration;
        public string departuretime = DateTime.Now.ToString("mm:ss");

        public string Location
        {
            get 
            {
              return location;
            }
            set
            {
                location = value;
            }
        }
        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
        public int FlightDuration
        {
            get 
            {
                return flightduration;
            }
            set 
            {
                flightduration = value;
            }
        }
        
    }
}
