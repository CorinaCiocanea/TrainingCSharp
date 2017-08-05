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
            int numberOfTasks = Convert.ToInt32(Console.ReadLine());

           string answer ;
            do 
            {
                 Console.Write("Type tasks for {0}: ", day);
                   answer = Console.ReadLine();
                     if (answer != "done")
                     {

                         tasks.Add(answer);
                     }

            } while (answer != "done");
            


        }
        public void Print()
        {
            Console.WriteLine("Display day: {0}", day);
            foreach (string task in tasks)
            {
                Console.WriteLine("Display task: {0}", task);
            }
        }

        public override string ToString()
        {
            return day.ToString();
        }
    }
}
