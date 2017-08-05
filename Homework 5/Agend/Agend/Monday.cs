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
            int numberOfTasks = Convert.ToInt32(Console.ReadLine());

            string[] tasks = new string[numberOfTasks];

            for (int i = 0; i < numberOfTasks; i++)
            {
                Console.Write("Type tasks for Monday: ");
                tasks[i] = Console.ReadLine();
            }

            string result = this.Concatenation(tasks);
            Console.WriteLine("Monday : {0}", result);
        }

        private string Concatenation(string[] inputWords)
        {
            if (inputWords == null || inputWords.Length == 0)
                return null;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (string word in inputWords)
            {
                stringBuilder.Append(word + ",");
            }
            return stringBuilder.ToString();
        }

    }
}
