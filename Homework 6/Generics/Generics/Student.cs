using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student : IPerson
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
        public override string ToString()
        {
            return string.Format("Student[name={0},CNP={1},datebirth={2}]", Name, CNP, DateBirth);
        }
    }
}
