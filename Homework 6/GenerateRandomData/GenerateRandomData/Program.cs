using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pers = new List<Person>();

            IList<Student> generatedStudents = Generate<Student>(10);

            IList<Person> generatedPersons = Generate<Person>(5);
            //Console.WriteLine("{0}", );
            //Person p = new Person();

            Console.ReadLine();
        }
        public static IList<T> Generate<T>(int n) where T : Person, new()
        {
            Random r = new Random();
            string[] names = { "alex", "abigail", "adele", "adrian" };
            List<T> instancesList = new List<T>();
            do
            {
                var instance = new T();
                instance.Age = r.Next(1, 99);
                instancesList.Add(instance);
                instance.Name = "Alex" + r.Next(1, 99);
                instance.Name = names[r.Next(0, names.Length - 1)];
                n--;

            } while (n != 0);

            return instancesList;
        }

        
    }
}
