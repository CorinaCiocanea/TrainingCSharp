using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Agend
{
   
    class DailyAgenda 
    {
        readonly Day day;
        private List<string> tasks;
        public DailyAgenda(Day day)
        {
            this.day = day;
            tasks = new List<string>();
        }

        public void Read()
        {
            Console.WriteLine("Enter the number of tasks for {0} :", day);
            int numarDeTaskuri = Convert.ToInt32(Console.ReadLine());

           string s ;
            do 
            {
                 Console.Write("Type tasks for {0}: ", day);
                   s = Console.ReadLine();
                     if (s != "done")
                     {

                         tasks.Add(s);
                     }

               

            } while (s != "done");
            


        }
        public void Print()
        {
            Console.WriteLine("afisam ziua: {0}", day);
            foreach (string task in tasks)
            {
                Console.WriteLine("afisam task: {0}", task);
            }
        }

        public override string ToString()
        {
            return day.ToString();
        }
    }
}
