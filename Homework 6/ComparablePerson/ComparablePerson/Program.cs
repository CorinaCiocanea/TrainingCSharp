using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparablePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person> 
            { new Person {Name = "Radu", Age = 18},
              new Person {Name = "Alex", Age = 17},
              new Person {Name = "Jan", Age = 24},
              new Person {Name = "Max", Age = 17},
              new Person {Name = "Micky", Age = 19},
              new Person {Name = "Jim", Age = 14},
              new Person {Name = "Ion", Age = 25},
            
            };
            persons.Sort();
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadLine();
           
        }
    }
}
