using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextCaracter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"WriteAllInputToFile.txt";
            string[] ArrLines;
            int n, i;
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine("1");
                fileStr.WriteLine("a");
                fileStr.WriteLine("0");
            }
            Console.Write(" Input number of lines to write in the file  :");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];
           
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.WriteAllLines(fileName, ArrLines);

            //TextInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.getValue());
            Console.ReadLine();
        }
    }
}
