using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int[] array2 = new int[20];
            int[] array3 = new int[20];
            int n, i, j=0, k=0;

             Console.Write("Number of items :");
	          n = Convert.ToInt32(Console.ReadLine()); 	   
   
            Console.WriteLine("Input {0} elements in the array: ",n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array2[j] = array[i];
                    j++;
                }
                else
                {
                    array3[k] = array[i];
                    k++;
                }
            }
            Console.WriteLine("the elements even : \n");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine("{0} ", array2[i]);
            }

            Console.WriteLine("the elements odd:\n");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine("{0} ", array3[i]);
            }
            Console.ReadLine();
        }
    }
}
