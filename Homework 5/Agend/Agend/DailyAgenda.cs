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


            for (int i = 0; i < numarDeTaskuri; i++)
            {
                Console.Write("Type tasks for {0}: ", day);
                string[] m = new string[10];
                tasks.Add(Console.ReadLine());
            }
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
