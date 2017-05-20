using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ComparablePerson
{
  public class Person : IComparable<Person>
    {   
       
        public int age;
        public string name;

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
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

        }
        public override string ToString()
        {
            return Name + " , " + Age.ToString();
        }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age)
                return 1;
            else if (this.Age < other.Age)
                return -1;
            else
                return 0;
        }

    }
}
