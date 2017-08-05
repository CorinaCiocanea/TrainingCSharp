using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sizeMatrix;
            int[,] array = new int[10, 10];
            int[] rowsSum = new int[10];
            int[] colSum = new int[10];

            Console.Write("The size matrix : ");
            sizeMatrix = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < sizeMatrix; i++)
            {
                for (j = 0; j < sizeMatrix; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < sizeMatrix; i++)
            {
                for (j = 0; j < sizeMatrix; j++)
                    Console.Write("{0}  ", array[i, j]);
                   Console.Write("\n");
            }

            for (i = 0; i < sizeMatrix; i++)
            {
                rowsSum[i] = 0;
                for (j = 0; j < sizeMatrix; j++)
                    rowsSum[i] = rowsSum[i] + array[i, j];
            }


            for (i = 0; i < sizeMatrix; i++)
            {
                colSum[i] = 0;
                for (j = 0; j < sizeMatrix; j++)
                    colSum[i] = colSum[i] + array[j, i];
            }

            Console.Write("The sum or rows and columns of the matrix is :\n");
            for (i = 0; i < sizeMatrix; i++)
            {
                for (j = 0; j < sizeMatrix; j++)

                Console.Write("{0}    ", array[i, j]);
                Console.Write("{0}    ", rowsSum[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < sizeMatrix; j++)
            {
                Console.Write("{0}  ", colSum[j]);
            }
            Console.ReadLine(); 
        }
    }
}
