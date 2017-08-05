using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestPerson
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        private DateTime birthDate;
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            birthDate = new DateTime(1984, 11, firstName.Length);

        }
        public virtual string GetFullName()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }
        public virtual string GenerateCode()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }
        public void PrintDateTime()
        {
            System.Console.WriteLine(birthDate);
        }

    }
    public class Student : Person
    {
        public Student(string firstName, string lastName)
            : base(lastName, lastName)
        {

        }

        public override string GetFullName()
        {
            return string.Format("{0} {1}", lastName, firstName);
        }
        public override string GenerateCode()
        {
            return string.Format("Student {0} {1}." + lastName, firstName[0]);
        }

    }

    public class Player : Student
    {
        private string userName;
        public Player(string firstName, string lastName, string userName)
            : base(firstName, lastName)
        {
            this.userName = userName;
            userName = "Player " + userName;
        }

        public override string GenerateCode()
        {
            return "Player " + userName;
        }
        public override string GetFullName()
        {
            return string.Format("Player {0} {1} {2}", userName, lastName, firstName);
        }

    }
}
