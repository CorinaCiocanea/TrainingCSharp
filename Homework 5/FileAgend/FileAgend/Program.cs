using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileAgend
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
          
            List<Agend> Agends = new List<Agend>();

           string[] allLines = File.ReadAllLines(fileName);
           
           
           foreach (string line in allLines)
           {
               string[] item = line.Split(',', '{', '}', ':');
                  for (int i = 0; i < item.Length; i++)
                  Console.WriteLine("{0}", item[i]);
              
               Agend CurentA = new Agend();
               CurentA.dDays = item[0];
               CurentA.tTasks = item[2];
               CurentA.pPriority = item[3];
              CurentA.hHour = int.Parse(item[4]);
               Agends.Add(CurentA);
               

               
           }
           foreach (Agend ag in Agends)
           {
               
             Console.WriteLine("the days: {0}, task: {1}, level: {2}, at hour: {3}", ag.dDays, ag.tTasks, ag.pPriority, ag.hHour);
             System.Console.WriteLine("Type day for which to display tasks");
             var answer = Console.ReadLine();
           
           }
           
          
           //foreach (string line in allLines)
           //{
           //    string[] arr1 = line.Split('{');
           //    foreach (string str in arr1)
           //    {
           //        string[] arr2 = str.Split('}');
           //        for (int j = 0; j < arr2.Length; j++)
           //            Console.WriteLine(arr2[j]);
           //    }
           //}
    
             
           Console.ReadLine();
        }
    }
}
