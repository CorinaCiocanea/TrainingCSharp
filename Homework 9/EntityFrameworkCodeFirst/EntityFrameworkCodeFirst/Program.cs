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
          //  Student name;
            var universty = new UniverstyDatabaseConnection();

            List<Student> studentList = new List<Student>() {
                new Student { LastName = "Ion", FirstName = "Marin", BirthDate = new DateTime(1991, 3, 17), CNP = "1278748322", Specializations = "English", YearOfStudy = 2 },
                new Student { LastName = "Maria", FirstName = "Vasi", BirthDate = new DateTime(1990, 6, 10), CNP = "23278748322", Specializations = "Geography", YearOfStudy = 1},
                new Student { LastName = "Vicky", FirstName = "Max", BirthDate = new DateTime(1993, 4, 20), CNP = "13178748322", Specializations = "Informatics", YearOfStudy = 4},
                new Student { LastName = "Max", FirstName = "Marin", BirthDate = new DateTime(1991, 9, 11), CNP = "1278748343", Specializations = "Sociology", YearOfStudy = 2},
                new Student { LastName = "Merlin", FirstName = "Ieremia", BirthDate = new DateTime(1999, 3, 16), CNP = "1278748566", Specializations = "History", YearOfStudy = 3 }
        };

          foreach (var stud in studentList)
          {
              universty.Students.Add(stud);
          }
            universty.SaveChanges();
            Console.WriteLine(universty.Students.Count());
           
            var a1 = from b in universty.Students
                     select b;
            foreach (var item in a1)
            {
                Console.WriteLine(item.FirstName);
            }

          //IEnumerable<Student> a2 = from item2 in universty.Students
          //           where item2.Specializations.Contains("English")
          //           orderby item2.BirthDate descending
          //           select item2;
          //foreach (var item in a2)
          //{
          //    Console.WriteLine(item.FirstName);
          //}

           
          //IEnumerable<Student> a3 = from item2 in universty.Students
          //                          where item2.Specializations.Contains("English")
          //                          orderby item2.YearOfStudy descending
          //                          select item2;
          //foreach (var item in a3)
          //{
          //    Console.WriteLine(item.FirstName);
          //}


            Console.ReadLine();
        }
    }
}
