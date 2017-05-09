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
            int[] arr = new int[10];
            int i, j;
            string yesAnswr = "y";
            string noAnswer = "n";
            string rasp;
            string userInput;
            bool repeat = true;
          //  for (i = 0; i < arr.Length; i++)
            while (repeat)
            {
                Console.Write("Do you want to add more numbers (y/n)?");
                rasp = Console.ReadLine();
                if(rasp == yesAnswr)
                {
                    Console.Write(string.Format("Please type an integer number"));
                    userInput = Console.ReadLine();
              
                    int newItem;
                   
                    if (int.TryParse(userInput, out newItem))
                    {

                        //for (i = 0; i < arr.Length; i++)
                            arr = arr.Concat(new int[] { newItem, 1 }).ToArray();
                       
                    }
                    else
                    {
                        Console.Write(string.Format("That was not a number"));
                    }
                    
                }
                else 
                if(rasp == noAnswer)
                {
                    repeat = false;
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Value in index {0}:\t{1}", i, arr[i]);
            }


            Console.WriteLine("prime:");
            for (i = 0; i < arr.Length; i++)
            {
                for (j = 2; j < arr[i]; j++)
                    if ((arr[i] % j == 0))
                    {
                        Console.WriteLine("{0}: not prime", arr[i]);
                        break;
                    }
                if (j == arr[i])
                {
                    Console.WriteLine("{0} : Is a prime", arr[i]);
                }
            }
            //Console.Write("\n"); 
               
                Console.ReadLine();
        }
       
    }
}
