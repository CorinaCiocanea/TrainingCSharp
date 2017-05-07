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
            string s = "da";
            string s2 = "nu";
            string rasp;
            //ring rasp2;
            Console.Write("Do you want to add more numbers?: ");
            rasp = Console.ReadLine();
            while (s == rasp)
            {

                Console.Write("Input the size of list : ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    string userInput;
                    int newItem;
                    do
                    {
                        Console.Write(string.Format("Enter item #{0}: ", i));

                        userInput = Console.ReadLine();
                    } while (!int.TryParse(userInput, out newItem));

                    items.Add(newItem);

                }
                Console.WriteLine("Lista is:");


                for (i = 0; i < n; i++)
                    Console.WriteLine("{0} ", items[i]);

                Console.WriteLine("prime:");
                for (i = 0; i < n; i++)
                {
                    for (j = 2; j < items[i]; j++)
                        if ((items[i] % j == 0))
                        {
                            Console.WriteLine("{0}: not prime", items[i]);
                            break;
                        }
                    if (j == items[i])
                    {
                        Console.WriteLine("{0} : Is a prime", items[i]);
                    }
                }

                break;
            }
            while (s2 == rasp)
            {
                Console.WriteLine("Finish");
                break;
            }

            Console.ReadLine();

        }
       
    }
}
