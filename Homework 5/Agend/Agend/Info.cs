using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Agend
{
    class Info
    {
        string day;
        string task;
        string str;
        int n;

        public void inserare()
        {
            
            ////Console.WriteLine("Enter args String:");
            ////str = Console.In.ReadLine();
            Console.Write("days: ");
            day=Console.ReadLine();
            Console.Write("task: ");
            task=Console.ReadLine();


        }
        public void afisare()
        {
           // Console.WriteLine("afisam task: {0}", str);
            Console.WriteLine("afisam ziua: {0}", day);
            Console.WriteLine("afisam task: {0}", task);
            //Console.WriteLine("afisam task: {0}", task);
        }
    }
}
