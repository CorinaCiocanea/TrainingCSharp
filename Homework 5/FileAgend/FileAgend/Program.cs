using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAgend
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            char shapeSeparator = ',';
           // int count=0;
           string[] allLines = File.ReadAllLines(fileName);
           foreach (string line in allLines)
           {
               string[] item = line.Split(shapeSeparator);
               Console.WriteLine("{0}", item[1]);
           }
           Console.WriteLine("{0}", allLines);
             
           Console.ReadLine();
        }
    }
}
