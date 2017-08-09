using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
//using System.Data.DataSetExtensions;
//using System.Core;
using System.Data.Entity;


namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Student name;
            var universty = new UniverstyDatabaseConnection();
            name = new Student() { FirstName = "Radu", LastName = "Ion", CNP = "1232787238", BirthDate = new DateTime(1991, 3, 17), Specializations = "English" };
                  // new Student() { FirstName = "Radu", LastName = "Ion", CNP = "1232787238", BirthDate = new DateTime(1991, 3, 17), Specializations = "English" };
            universty.Students.Add(name);
            universty.SaveChanges();
            Console.WriteLine(universty.Students.Count());

            var a1 = from b in universty.Students
                     select b;
            foreach (var item in a1)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
}
