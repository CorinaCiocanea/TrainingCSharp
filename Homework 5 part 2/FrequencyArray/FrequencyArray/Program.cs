using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
	        int[] frequency = new int[100];
             int n, i, j, contor;

             Console.Write("Number of items :");
	          n = Convert.ToInt32(Console.ReadLine()); 	   
   
            Console.WriteLine("Input {0} elements in the array: ",n);

                for(i=0;i<n;i++)
            {

	          Console.Write("element - {0} : ",i);
   	          array[i] = Convert.ToInt32(Console.ReadLine()); 		  
		      frequency[i] = -1;
	        }
              for(i=0; i<n; i++)
              {
             contor = 1;
             for(j=i+1; j<n; j++)
          {
            if(array[i]==array[j])
            {
                contor++;
                frequency[j] = 0;
            }
        }

        if(frequency[i] != 0)
        {
            frequency[i] = contor;
        }
    }
      Console.WriteLine("The frequency for elements : ");
    for (i = 0; i < n; i++)
    {
        if (frequency[i] != 0)
        {
            Console.WriteLine("{0} is {1}", array[i], frequency[i]);
        }
    }
    Console.ReadLine();
        }
    }
}
