using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Agend
{
    public enum Day
    {
        Monday,
        Tuesday,
      //  Wednesday,
      //  Thursday,
      //  Friday,
      //  Saturday,
       // Sunday
    }
    class Agenda
    {
        readonly DailyAgenda [] vect = new DailyAgenda[2];
        string str;
        const int n=7;
        public Agenda()
        {
            str = "default";
            vect = new DailyAgenda[2];
            int i = 0;

            foreach (Day day in Enum.GetValues(typeof(Day)))
            {
                vect[i] = new DailyAgenda(day);
                i++;
            }
        }

        public void Read()
        {
            foreach (var dailyAgenda in vect)
            {
                dailyAgenda.Read();
              //  Console.WriteLine(dailyAgenda);
            }
        }


        public void Print()
        {
            System.Console.WriteLine("Type day for which to display tasks");
            var answer = Console.ReadLine();
            Day chosenDay;
            if (Enum.TryParse(answer, out chosenDay))
            {
                vect[(int)chosenDay].Print();
            }
        }

    }
}
