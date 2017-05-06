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
            int i, n, poz, elem, j;
           
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted : ");
            elem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position :");
            poz = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr[i]);
            
            for (i = n; i >= poz; i--)
                arr[i] = arr[i - 1];
           
            arr[poz - 1] = elem;


            Console.Write("After Insert the element the new list is :\n");
            for (i = 0; i <= n; i++)
                Console.WriteLine("{0} ", arr[i]);

            Console.WriteLine("prime:");
            for (i = 0; i < arr.Length ; i++)
            {
               for(j = 2; j < arr[i]; j++)
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
            Console.Write("\n"); 
               
                Console.ReadLine();
        }
       
    }
}
