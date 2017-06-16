using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace CodeFirst
{
   public class SampleData 
    {
       new List<Student> list = new List<Student>()
       {
           new Student { LastName = "Ion", FirstName = "Marin", BirthDate = new DateTime(1991, 3, 17), CNP = 1278748322, Specialization = Specializations.English},
           new Student { LastName = "Maria", FirstName = "Vasi", BirthDate = new DateTime(1990, 6, 10), CNP = 23278748322, Specialization = Specializations.Geography},
           new Student { LastName = "Vicky", FirstName = "Max", BirthDate = new DateTime(1993, 4, 20), CNP = 13178748322, Specialization = Specializations.Informatics},
           new Student { LastName = "Max", FirstName = "Marin", BirthDate = new DateTime(1991, 9, 11), CNP = 1278748343, Specialization = Specializations.Sociology},
           new Student { LastName = "Merlin", FirstName = "Ieremia", BirthDate = new DateTime(1999, 3, 16), CNP = 1278748566, Specialization = Specializations.History}
       };
    }
}
