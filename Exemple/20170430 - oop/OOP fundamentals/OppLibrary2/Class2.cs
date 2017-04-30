using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppLibrary2
{
    public class C
    {
        string c1;
        string c2;
        protected int c3;

        public C()
        {
            Console.WriteLine("Default constructor");
            c3 = 7;
        }

        public C(int i, string p1) : this(p1)
        {
            Console.WriteLine(i);
        }

        public C(string p1) //: this()
        {
            Console.WriteLine(p1);
        }
    }

    public class Derived : C
    {
        public Derived()
        {
            Console.WriteLine("Derived constructor");
            System.Console.WriteLine(c3);
        }
        //public Derived(string s)
        //{

        //}
    }
}
