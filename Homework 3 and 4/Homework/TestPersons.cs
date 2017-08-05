using System;

namespace Homework
{
    /// <summary>
    /// Ce va afisa metoda PrintNames din clasa TestPersons si de ce? Daca exista cod care nu compileaza ce putem schimba in metoda PrintNames pentru a-l face sa compileze (fara a schimba clasele Person, Student sau Player)?
    /// </summary>
    public class Person
    {
        protected string firstName;
        protected string lastName;
        private DateTime birthDate;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthDate = new DateTime(firstName.Length, 11, 1984);
        }
     
        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }

        public void PrintDateTime()
        {
            System.Console.WriteLine(birthDate);
        }
    }

    public class Student: Person
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override string GetFullName()
        {
            return string.Format("{0} {1}", lastName, firstName);
        }

        public string GenerateCode()
        {
            return  string.Format("Student {0} {1}." + lastName, firstName[0]) ;
        }
    }


    public class Player : Student
    {
        private string userName;
        public Player(string firstName, string lastName, string userName) : base(firstName, lastName)
        {
            this.userName = userName;
            userName = "Player " + userName;
        }

        public string GenerateCode()
        {
            return "Player " + userName;
        }

        public override string GetFullName()
        {
           return string.Format("Player {0} {1} {2}", userName, lastName, firstName);
        }
    }

    public static class TestPersons
    {
        public static void PrintNames()
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
