using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plane> airplane = new List<Plane>
            {
                new Plane { NumberRow = 20, NumberPlaceRow = 4 },
                new Plane { NumberRow = 24, NumberPlaceRow = 8 },
                new Plane { NumberRow = 40, NumberPlaceRow = 6 },
                new Plane { NumberRow = 30, NumberPlaceRow = 10 },
                new Plane { NumberRow = 30, NumberPlaceRow = 2 },
                new Plane { NumberRow = 28, NumberPlaceRow = 4 },
                new Plane { NumberRow = 25, NumberPlaceRow = 8 },

            };

            List<Flight> flightplane = new List<Flight>
            {
                new Flight { Location = "Bucharest", Destination = "Madrid", FlightDuration = 8, departuretime = "16:30"},
                new Flight { Location = "Bucharest", Destination = "Rome", FlightDuration = 6, departuretime = "16:30"},
                new Flight { Location = "Paris", Destination = "Madrid", FlightDuration = 4, departuretime = "16:30"},
                new Flight { Location = "Vienna", Destination = "Rome", FlightDuration = 2, departuretime = "16:30"},
                new Flight { Location = "Berlin", Destination = "Bucharest", FlightDuration = 5, departuretime = "16:30"},
                new Flight { Location = "Athens", Destination = "Berlin", FlightDuration = 7, departuretime = "16:30"},

            };
            List<string> list = new List<string>();

            foreach (Day day in Enum.GetValues(typeof(Day)))
            {
                list.Add(day.ToString());
                Console.WriteLine(day);
            }

            
             Console.ReadLine();
        }
    }
}
