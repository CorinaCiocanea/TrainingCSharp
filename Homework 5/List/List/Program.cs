using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
       //const string s = "da";
       // const string rasp;

        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            int n, i, j;
            string yesAnswer = "y";
            string noAnswer = "n";
            string rasp;
            //ring rasp2;
            string userInput;


            bool repeat = true;

            while (repeat)
            {
                Console.Write("Do you want to add more numbers (y/n)?");
                rasp = Console.ReadLine();
                if (rasp == yesAnswer)
                {

                    Console.Write(string.Format("Please type an integer number"));
                    userInput = Console.ReadLine();
                    int newItem;
                    if (int.TryParse(userInput, out newItem))
                    {
                        items.Add(newItem);
                    }
                    else
                    {
                        Console.Write(string.Format("That was not a number"));
                    }
                }
                else if (rasp == noAnswer)
                {
                    repeat = false;
                }
            }


            Console.WriteLine("Lista is:");


            for (i = 0; i < items.Count; i++)
                Console.WriteLine("{0} ", items[i]);

            Console.WriteLine("prime:");
            for (i = 0; i < items.Count; i++)
            {
                if (IsPrime(items[i]))
                {
                    Console.WriteLine(items[i]);
                }
            }

            Console.ReadLine();

        }

        private static bool IsPrime(int n)
        {
            for (int j = 2; j < n; j++)
            {
                if ((n % j == 0))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
