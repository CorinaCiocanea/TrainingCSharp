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
                   Major = new List<string>() {"Math", "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 2}, 
                        new Curs { NameCurs = "English", Hour = 4}}},
                             
               new Student { FirstName="Tomita", LastName="Jerry", DateBirth = "11/14/1986", Age=24,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Math", "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Arts", Hour = 5}, 
                        new Curs { NameCurs = "Science", Hour = 2}}},
               new Student { FirstName="Max", LastName="Anton", DateBirth = "12/20/1986", Age=26,
                   Hobby = new List<string>() {"Dancing", "Cycling", "Reading"},
                   Major = new List<string>() {"Math", "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 10 }, 
                        new Curs { NameCurs = "Science", Hour = 1}, 
                        new Curs { NameCurs = "English", Hour = 4}}},
               new Student { FirstName="Tomi", LastName="Jera", DateBirth = "12/03/1986", Age=25,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Math", "English", "Literatura"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 9 }, 
                        new Curs { NameCurs = "Science", Hour = 11}, 
                        new Curs { NameCurs = "English", Hour = 14}}},
               new Student { FirstName="Ion", LastName="Max", DateBirth = "12/03/1986", Age=20,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Math", "English", "Desen"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 2 }, 
                        new Curs { NameCurs = "Science", Hour = 3}, 
                        new Curs { NameCurs = "English", Hour = 10}}},
               new Student { FirstName="Alex", LastName="Jeri", DateBirth = "12/03/1986", Age=24,
                   Hobby = new List<string>() {"Dancing", "Cycling", "Reading"},
                   Major = new List<string>() {"Math"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 17 }, 
                        new Curs { NameCurs = "Science", Hour = 19}, 
                        new Curs { NameCurs = "English", Hour = 12}}},
               new Student { FirstName="Mac", LastName="Anton", DateBirth = "12/03/1986", Age=30,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Math", "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "France", Hour = 16 }, 
                        new Curs { NameCurs = "Music", Hour = 14}, 
                        new Curs { NameCurs = "English", Hour = 6}}},
              new Student { FirstName="Andre", LastName="Ieremia", DateBirth = "12/03/1986", Age=29,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() { "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 9 }, 
                        new Curs { NameCurs = "Science", Hour = 12}, 
                        new Curs { NameCurs = "English", Hour = 18}}},
              new Student { FirstName="Marius", LastName="Vasile", DateBirth = "12/03/1986", Age=28,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Math", "Arts"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 14}, 
                        new Curs { NameCurs = "English", Hour = 13}}},
              new Student { FirstName="Ana", LastName="Jer", DateBirth = "12/03/1986", Age=27,
                   Hobby = new List<string>() {"Dancing", "Cycling"},
                   Major = new List<string>() {"Science", "English"},
                   Course = new List<Curs> {
                        new Curs { NameCurs = "Maths", Hour = 6 }, 
                        new Curs { NameCurs = "Science", Hour = 11}, 
                        new Curs { NameCurs = "English", Hour = 2}}}
                            
                             
                       };
            //Student s = new Student();
          
           //var query = from student in students
           //            group student by student.Age into g
           //            orderby g.Key descending
           //            select new{
                       
           //                       StudOld - g.ToList() 
           //                      }).ToList();

            //IEnumerable<Student> query2 =
            //    from student in students
            //    where student.Course > 2
            //    select student;
                
            IEnumerable<Student) query3 = 
                from student in students
                where student.Hobby == "Reading"
                select student;
         
        }
    }
}