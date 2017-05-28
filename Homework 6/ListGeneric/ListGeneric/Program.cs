using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int> list = new SortedList<int>();
            list.Add(5);
            list.Add(2);
            list.Add(1);
            list.Add(7);
            list.Add(10);
            list.Add(5);
            list.Add(3);

            Console.WriteLine(list.GetMax());
            
            foreach (int l in list)
            {
                Console.WriteLine(l + " ");
            }
            foreach (int l in list.GetItems(Direction.Asc))
            {
                Console.WriteLine(l + " ");
            }
            foreach (int l in list.GetItems(Direction.Desc))
            {
                Console.WriteLine(l + " ");
            }
             SortedList<Person> persons = new SortedList<Person> 
            // persons.Add(new Person {Name = "Radu", Age = 18});
            // persons.Add(new Person {Name = "Alex", Age = 17});
            // persons.Add(new Person {Name = "Jan", Age = 24})
              
            
            
            Console.WriteLine(persons.GetMax());
            Console.ReadLine();
          
        }
    }
}
