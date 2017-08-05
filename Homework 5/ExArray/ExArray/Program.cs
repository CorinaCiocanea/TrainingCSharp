using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i, j;
            string yesAnswer = "y";
            string noAnswer = "n";
            string answer;
            string userInput;
            bool repeat = true;

            while (repeat)
            {
                Console.Write("Do you want to add more numbers (y/n)?");
                answer = Console.ReadLine();
                if (answer == yesAnswer)
                {
                    Console.Write(string.Format("Please type an integer number"));
                    userInput = Console.ReadLine();

                    int newItem;

                    if (int.TryParse(userInput, out newItem))
                    {
                        array = array.Concat(new int[] { newItem, 1 }).ToArray();
                    }
                    else
                    {
                        Console.Write(string.Format("That was not a number"));
                    }

                }
                else
                    if (answer == noAnswer)
                    {
                        repeat = false;
                    }
            }
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Value in index {0}:\t{1}", i, array[i]);
            }


            Console.WriteLine("prime:");
            for (i = 0; i < array.Length; i++)
            {
                for (j = 2; j < array[i]; j++)
                    if ((array[i] % j == 0))
                    {
                        Console.WriteLine("{0}: not prime", array[i]);
                        break;
                    }
                if (j == array[i])
                {
                    Console.WriteLine("{0} : Is a prime", array[i]);
                }
            }


            Console.ReadLine();
        }

    }
}
