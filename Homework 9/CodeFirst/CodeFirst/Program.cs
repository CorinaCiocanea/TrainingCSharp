using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SampleData())
            {
                Console.Write("Enter a name for a new Blog: ");
                var x = db.Database.Connection.ConnectionString;
                var name = Console.ReadLine();

            var blog = new Student { LastName = name, FirstName = "Vasi", BirthDate = new DateTime(1990, 6, 10), CNP = 23278748322, YearOfStudy = 1, Specialization=Specializations.English };
                
       //var list = new List<Student>()
       //{
       //    new Student { LastName = "Ion", FirstName = "Marin", BirthDate = new DateTime(1991, 3, 17), CNP = 1278748322, Specialization = Specializations.English},
       //    new Student { LastName = "Maria", FirstName = "Vasi", BirthDate = new DateTime(1990, 6, 10), CNP = 23278748322, Specialization = Specializations.Geography},
       //    new Student { LastName = "Vicky", FirstName = "Max", BirthDate = new DateTime(1993, 4, 20), CNP = 13178748322, Specialization = Specializations.Informatics},
       //    new Student { LastName = "Max", FirstName = "Marin", BirthDate = new DateTime(1991, 9, 11), CNP = 1278748343, Specialization = Specializations.Sociology},
       //    new Student { LastName = "Merlin", FirstName = "Ieremia", BirthDate = new DateTime(1999, 3, 16), CNP = 1278748566, Specialization = Specializations.History}
       //};
                db.Studentss.Add(blog);
                db.SaveChanges();


                var query = from b in db.Studentss
                            orderby b.LastName
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.LastName);
                }


                //IEnumerable<Student> a2 = from item2 in db.Studentss
                //                          where item2.Specialization.CompareTo(Specializations.English)
                //                          orderby item2.BirthDate descending
                //                          select item2;
                //foreach (var item in a2)
                //{
                //    Console.WriteLine(item.FirstName);
                //}


                //IEnumerable<Student> a3 = from item2 in db.Studentss
                //                          where item2.Specialization.Contains("English")
                //                          orderby item2.YearOfStudy descending
                //                          select item2;
                //foreach (var item in a3)
                //{
                //    Console.WriteLine(item.FirstName);
                //}




                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(); 
            }

        }
    }
    //public class BloggingContext : DbContext
    //{
    //    public DbSet<Student> Blogs { get; set; }
    //   // public DbSet<Post> Posts { get; set; }
    //} 
}
