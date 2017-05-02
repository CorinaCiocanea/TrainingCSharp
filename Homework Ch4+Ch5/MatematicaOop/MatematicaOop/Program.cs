using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaOop
{
    class Program
    {
        static void Main(string[] args)
        {
            var triple = new TripleFunc();
            var quad = new QuadFunc();
            Console.WriteLine(((IdentityFunc)triple).GetValue(3));
            Console.WriteLine(((IdentityFunc)quad).GetValue(3));
            Console.WriteLine(((DoubleFunc)triple).GetValue(3));
            Console.WriteLine(((DoubleFunc)quad).GetValue(3));
            Console.WriteLine((triple).GetValue(3));
            Console.WriteLine(((TripleFunc)quad).GetValue(3));
            Console.WriteLine(((IFunc)triple).GetValue(3));
            Console.WriteLine(((IFunc)quad).GetValue(3));
            Console.ReadLine();
        }
    }
}
