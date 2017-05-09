using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueArray
{
    public class RemoveDup

    {
        readonly int[] array = new int[10];
        int i, n, k, j, ctr = 0;

         public void RemoveDuplicates()
         {
             Console.Write("Input the number of elements to be stored in the array :");
             n = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input {0} elements in the array :\n", n);
             for (i = 0; i < n; i++)
             {
                 Console.Write("element - {0} : ", i);
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }

             for (i = 0; i < n; i++)
            {
                ctr = 0;

                for (j = 0; j < i - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (array[i] == array[k])
                    {
                        ctr++;
                    }
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", array[i]);
                }
              
              }
        
        }
        
    }
}
