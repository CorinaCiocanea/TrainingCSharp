using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Teacher : IPerson
    {
       public string name;
        public long cnp;
        public DateTime dateBirth;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long CNP
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            set
            {
                dateBirth = value;
            }
        }
        //public Teacher()
        //{ 
        
        //}
        //public Teacher(string Name, long CNP, DateTime DateBirth)
        //{
        //    this.Name = Name;
        //    this.CNP = CNP;
        //    this.DateBirth = DateBirth;

        //}
        public override string ToString()
        {
            return string.Format("Student[name={0},CNP={1},datebirth={2}]", Name, CNP, DateBirth);
        }

        
    }
}
