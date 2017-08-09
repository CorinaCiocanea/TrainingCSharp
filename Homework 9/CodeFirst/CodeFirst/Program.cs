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
                var name = Console.ReadLine();

                var blog = new Student { LastName = name };
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
