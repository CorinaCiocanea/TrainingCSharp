using OppLibrary2;
using System;

namespace OOP_fundamentals
{
    class Program
    {
        public class Contact
        {
            public int Age;
        }

        static void Main(string[] args)
        {
            Contact c = new Contact();
           // int a;
         
            System.Console.WriteLine(c.Age);
            //System.Console.WriteLine(a);


            MethodWithParameters(ref c.Age);
            System.Console.WriteLine(c.Age);
            MethodWithParameters(ref c);
            System.Console.WriteLine(c.Age);
            MethodChangeContact(ref c);
            System.Console.WriteLine(c.Age);

            //MethodWithRefParameters(ref c.Age);
            //System.Console.WriteLine(c.Age);
            //MethodWithOutParameters(out c.Age);
            //System.Console.WriteLine(c.Age);


            System.Console.ReadLine();

        }

        public static void MethodWithParameters(ref int a) //copy of int 
        {
            a = 14;
        }

        public static void MethodWithParameters(ref Contact contact) //copy of contact, copy adress
        {
            contact.Age = 14;
        }

        public static void MethodChangeContact(ref Contact contact) // copy of contact
        {
            contact = new Contact(); // initialiaze new address 
            contact.Age = 15;
        }

        public static void MethodWithOutParameters(out int a)
        {
            a = 10;
        }

        public static void MethodWithRefParameters(ref int a)
        {
            a = 7;
        }
    }


}
