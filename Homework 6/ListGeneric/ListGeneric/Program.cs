using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int> list = new SortedList<int>();
            list.Add(5);
            list.Add(2);
            list.Add(1);
            list.Add(7);
            list.Add(10);
            list.Add(5);
            list.Add(3);
            
            
            foreach (int l in list)
            {
                Console.WriteLine(l + " ");
            }
           
           
            Console.ReadLine();
          
        }
    }
}
