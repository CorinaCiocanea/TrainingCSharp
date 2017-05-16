using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public DateTime DateBirth { get; set; }
      public string DateBirth = DateTime.Now.ToString("MM/dd/yyyy");
        public int Age { get; set; }
        public List<string> Hobby;
        public string Major;
        public List<Curs> Course;

    }
       
	         
         
     
    
}
