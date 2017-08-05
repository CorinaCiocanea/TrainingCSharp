using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100];
            int numberItems, i, j, temp;

            Console.Write("Number of items :");
            numberItems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array: ", numberItems);

            for (i = 0; i < numberItems; i++)
            {

                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < numberItems; i++)
            {
                for (j = i + 1; j < numberItems; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("The second largest element in an array {0}", array[1]);
            Console.ReadLine();
        }
    }
}
