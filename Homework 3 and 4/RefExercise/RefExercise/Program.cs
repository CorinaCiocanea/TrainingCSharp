using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefExercise
{

    class Program
    {

        public static void TestR(ref int x, ref int y)
        {
            x = 42;
            y = 42;
            System.Console.WriteLine(x == y);
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;

            TestR(ref a, ref b);

            Console.ReadLine();

        }

    }
}
