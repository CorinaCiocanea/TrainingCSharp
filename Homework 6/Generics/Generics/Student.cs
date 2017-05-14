using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student<T> : IPerson<string>
    {
        public string Name;
        public long CNP;
        public DateTime DateBirth;
        public Student()
        { 
         
        }
        public Student(string Name, long CNP, DateTime DateBirth) 
        {
            this.Name = Name;
            this.CNP = CNP;
            this.DateBirth = DateBirth;

        }
        public override string ToString()
        {
            return string.Format("Student[name={0},CNP={1},datebirth={2}]", Name, CNP, DateBirth);
        }
    }
}
