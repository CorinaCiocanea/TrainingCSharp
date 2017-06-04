using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
   public class Person : IComparable
    {

            private int age;
             private string name;

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
            public int CompareTo(object obj)
            {
                Person person = (Person) obj;
                if (person == null)
                {
                    return 1;
                }
                return CompareTo(person);
            }
        }
    }

