using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Player("Florin", "Nicorici", "chaos28");

            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(((Student)p1).GetFullName());
            System.Console.WriteLine(((Player)p1).GetFullName());

            System.Console.WriteLine(p1.GenerateCode());
            System.Console.WriteLine(((Player)p1).GenerateCode());
            System.Console.WriteLine(((Student)p1).GenerateCode());

            p1.PrintDateTime();
            ((Student)p1).PrintDateTime();
            ((Player)p1).PrintDateTime();


            Student p2 = new Player("Cristian", "Nicorici", "gemini30");
            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(((Person)p2).GetFullName());
            System.Console.WriteLine(((Player)p2).GetFullName());

            System.Console.WriteLine(p2.GenerateCode());
            System.Console.WriteLine(((Player)p2).GenerateCode());
            System.Console.WriteLine(((Student)p2).GenerateCode());

            p2.PrintDateTime();
            ((Student)p2).PrintDateTime();
            ((Player)p2).PrintDateTime();


             System.Console.ReadLine();
        }
    }
}
