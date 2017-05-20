using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student { FirstName="Tom", LastName="Jer", DateBirth = "12/03/1986", Age=21,
                   Hobby = new List<string>() {"Dancing", "Cycling", "Reading"},
                   Major = "Cycling",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 2}, 
                        new Curs { NameCurs = "English", Hour = 4}}},
                             
               new Student { FirstName="Tomita", LastName="Jerry", DateBirth = "11/14/1986", Age=24,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "Cycling",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Arts", Hour = 5}, 
                        new Curs { NameCurs = "Science", Hour = 2}}},
               new Student { FirstName="Max", LastName="Anton", DateBirth = "12/20/1986", Age=26,
                   Hobby = new List<string>() {"Dancing", "Cycling", "Reading"},
                   Major = "English",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Science", Hour = 1}}}, 
                     
               new Student { FirstName="Tomi", LastName="Jera", DateBirth = "12/03/1986", Age=25,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "Math",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 9 }, 
                        new Curs { NameCurs = "Science", Hour = 11}, 
                        new Curs { NameCurs = "English", Hour = 14}}},
               new Student { FirstName="Ion", LastName="Max", DateBirth = "12/03/1986", Age=20,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "Photography",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 2 }, 
                        new Curs { NameCurs = "Science", Hour = 3}, 
                        new Curs { NameCurs = "English", Hour = 10}}},
               new Student { FirstName="Alex", LastName="Jeri", DateBirth = "12/03/1986", Age=24,
                   Hobby = new List<string>() {"Dancing", "Cycling", "Reading"},
                   Major = "Photography",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 17 }, 
                        new Curs { NameCurs = "Science", Hour = 19}, 
                        new Curs { NameCurs = "English", Hour = 12}}},
               new Student { FirstName="Mac", LastName="Anton", DateBirth = "12/03/1986", Age=30,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "English",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "France", Hour = 16 }, 
                        new Curs { NameCurs = "Music", Hour = 14}, 
                        new Curs { NameCurs = "English", Hour = 6}}},
              new Student { FirstName="Andre", LastName="Ieremia", DateBirth = "12/03/1986", Age=29,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "English",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 9 }, 
                        new Curs { NameCurs = "Science", Hour = 12}, 
                        new Curs { NameCurs = "English", Hour = 18}}},
              new Student { FirstName="Marius", LastName="Vasile", DateBirth = "12/03/1986", Age=28,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "Math",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 14}, 
                        new Curs { NameCurs = "English", Hour = 13}}},
              new Student { FirstName="Ana", LastName="Jer", DateBirth = "12/03/1986", Age=27,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = "English",
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 11}, 
                        new Curs { NameCurs = "English", Hour = 2}}}
                            
                             
                       };
         
            var query = students.GroupBy(s => s.Age).OrderByDescending(g => g.Key).FirstOrDefault();

            var oldestStudent = from s in students
                                orderby s.Age descending
                                select s;
            foreach (var item in oldestStudent)
            {
                Console.WriteLine("Student name: {0}. Student age {1}", item.LastName, item.Age);
            }

            Console.WriteLine();

            var youngerStudent = from s in students
                                orderby s.Age ascending
                                select s;
            foreach (var item in youngerStudent)
            {
                Console.WriteLine("Student name: {0}. Student age {1}", item.LastName, item.Age);
            }

            Console.WriteLine();

            IEnumerable<Student> query3 =
                from student in students
                where student.Major.Contains("English")
                select student;
            foreach (var item in query3)
            {
                
                Console.WriteLine("Student name: {0}. Major {1}", item.LastName, item.Major);
            }

            Console.WriteLine();

            IEnumerable<Student> query4 =
            from student in students
                where student.Hobby.Contains("Reading")
                select student;
          
            foreach (var item in query4)
            {
                Console.WriteLine("Student name: {0}. Hobbies {1}", item.LastName, string.Join(",",item.Hobby));
            }

            Console.WriteLine();

            //var query5 =
            //    from student in students
            //    group student by student.Hobby into studGroup
            //    select new
            //        {

            //        };
            IEnumerable<Student> query5 =
            from student in students
            where student.Hobby.Contains("Reading")
            select student;
            int count = query5.Count();

            foreach (var item in query5)
            {
                Console.WriteLine("Student name: {0}. Hobbies {1}", count);
            }


            var query2 =
                from student in students
                where student.Course.Count > 2
                select student;
            foreach (var item in query4)
            {
                Console.WriteLine("Student name: {0}. Hobbies {1}", item.Course);
            }

           
                         
           
            //IEnumerable<Student> x = students.Where(p => p.Course.Count >= 2);
            Console.ReadLine();
            
          
          
                
          
        }
    }
}