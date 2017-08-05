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
        int i, k, j, contor = 0;
        int lengthArray;

         public void RemoveDuplicates()
         {
             Console.Write("Input the number of elements to be stored in the array :");
             lengthArray = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input {0} elements in the array :\n", lengthArray);
             for (i = 0; i < lengthArray; i++)
             {
                 Console.Write("element - {0} : ", i);
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }

             for (i = 0; i < lengthArray; i++)
            {
                contor = 0;

                for (j = 0; j < i - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        contor++;
                    }
                }
                for (k = i + 1; k < lengthArray; k++)
                {
                    if (array[i] == array[k])
                    {
                        contor++;
                    }
                }
                if (contor == 0)
                {
                    Console.Write("{0} ", array[i]);
                }
              
              }
        
        }
        
    }
}
