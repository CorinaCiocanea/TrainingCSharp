using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomData
{
    public class Person : Student
    {

        public int age;
        public string name;
        string[] names = { "alex", "abigail", "adele", "adrian" };
        Random r = new Random();

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

        public void Generate<T>(T value, int n)
        {

            n = r.Next(1, 100);
            age = r.Next(1, 99);
            //name = r.Next(names.Length);
            name = names[r.Next(0, names.Length - 1)];


        }


    }
}
