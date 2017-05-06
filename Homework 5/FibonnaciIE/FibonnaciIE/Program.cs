using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnaciIE
{
    class Program
    {
        private static List<int> fibs = new List<int>() { 1, 1 };
        static IEnumerable<int> F()
        {
            foreach (var fib in fibs)
            {
                yield return fib;
            }
            int a, b;
            while (true)
            {
                a = fibs.Last();
                b = fibs[fibs.Count() - 2];
                fibs.Add(a + b);
                yield return a + b;
            }
        }
  
        static void Main(string[] args)
        {
            //var generator = new Fibo(10);

            //foreach (var num in generator)
            //{
            //    Console.WriteLine(num);
            //    Console.ReadLine();
            //}
        }
    }
}
