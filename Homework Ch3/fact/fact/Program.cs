using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach(string a in args)
            //{
            //    System.Console.WriteLine(a);
            //}
         
            System.Console.WriteLine("number is: ");
            int n = int.Parse(Console.ReadLine());
           
            Console.WriteLine("The number you entered was {0} and it's factorial is {1}", n, Factorial(n));
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            int c, fact;
            fact = n;
            for (c = n - 1; c >= 1; c--)
            {
                fact = fact * c;
            }
            return fact;
        }
    }
}
