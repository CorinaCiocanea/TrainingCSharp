using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divide div = new Divide();
            //div.CalculatedDivide();
            Console.WriteLine("Example Throw");
            Console.WriteLine();

            ExampleClass1 exClass1 = new ExampleClass1();
            Console.WriteLine(exClass1.Method1());

            Console.WriteLine();
            Console.WriteLine("Example Throw Ex");
            Console.WriteLine();

            ExampleClass1 exClass11 = new ExampleClass1();
            Console.WriteLine(exClass11.MethodThrowEx());

            Console.WriteLine();

            ClassA clA = new ClassA();
            ClassB clB = new ClassB();
            ClassC clC = new ClassC();
            try
            {
                  clA.A();
                  //clB.B();
               // clC.C(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.ReadLine();
        }
    }
}
