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
            Person person1 = new Player("Florin", "Nicorici", "chaos28");

            System.Console.WriteLine(person1.GetFullName());
            System.Console.WriteLine(((Student)person1).GetFullName());
            System.Console.WriteLine(((Player)person1).GetFullName());

            System.Console.WriteLine(person1.GenerateCode());
            System.Console.WriteLine(((Player)person1).GenerateCode());
            System.Console.WriteLine(((Student)person1).GenerateCode());

            person1.PrintDateTime();
            ((Student)person1).PrintDateTime();
            ((Player)person1).PrintDateTime();


            Student person2 = new Player("Cristian", "Nicorici", "gemini30");
            System.Console.WriteLine(person2.GetFullName());
            System.Console.WriteLine(((Person)person2).GetFullName());
            System.Console.WriteLine(((Player)person2).GetFullName());

            System.Console.WriteLine(person2.GenerateCode());
            System.Console.WriteLine(((Player)person2).GenerateCode());
            System.Console.WriteLine(((Student)person2).GenerateCode());

            person2.PrintDateTime();
            ((Student)person2).PrintDateTime();
            ((Player)person2).PrintDateTime();


             System.Console.ReadLine();
        }
    }
}
