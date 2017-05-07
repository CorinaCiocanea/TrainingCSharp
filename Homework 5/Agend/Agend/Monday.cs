using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agend
{
    class Monday
    {
        public void Test()
        {
            Console.WriteLine("Enter the number of tasks for Monday :");
            int numarDeTaskuri = Convert.ToInt32(Console.ReadLine());

            string[] tasks = new string[numarDeTaskuri];

            for (int i = 0; i < numarDeTaskuri; i++)
            {
                Console.Write("Type tasks for Monday: ");
                tasks[i] = Console.ReadLine();
            }

            string rezultat = this.Concatenare(tasks);
            Console.WriteLine("Monday : {0}", rezultat);
        }

        private string Concatenare(string[] inputCuvinte)
        {
            if (inputCuvinte == null || inputCuvinte.Length == 0)
                return null;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (string cuvant in inputCuvinte)
            {
                stringBuilder.Append(cuvant + ",");
            }
            return stringBuilder.ToString();
        }

    }
}
