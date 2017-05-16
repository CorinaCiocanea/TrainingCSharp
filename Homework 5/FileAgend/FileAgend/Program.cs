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
          
         //List<Agend> Agends = new List<Agend>();
            Dictionary<string, List<Task>> Agends = new Dictionary<string, List<Task>>();

           string[] allLines = File.ReadAllLines(fileName);
           
           
           foreach (string line in allLines)
           {
               string[] tasks = line.Split(',');
               List<Task> dictionaryValue = new List<Task>();

               if (Agends.ContainsKey(tasks[0]))
               {
                   dictionaryValue = Agends[tasks[0]];
               }
               else
               {
                   dictionaryValue = new List<Task>();
               }

               for (int i = 1; i < tasks.Length; i++)
               {
                   Task Curent = new Task();
                   Curent.dDay = tasks[0];
                   string task = tasks[i];
                   task = task.TrimStart('{');
                   task = task.TrimEnd('}');

                   string[] taskProperties = task.Split(':');
                   //Task CurentB = new Task();
                   Curent.nName = taskProperties[0];
                   Curent.pPriority = taskProperties[1];
                   Curent.hHour = int.Parse(taskProperties[2]);

                   dictionaryValue.Add(Curent);
               }
               Agends.Add(tasks[0], dictionaryValue);

               
           }
           Console.WriteLine("Display tasks for day");
           var answer = Console.ReadLine();
           if (Agends.ContainsKey(answer))
           {
               List<Task> tasks = Agends[answer];
               foreach (var ag in tasks)
               {

                   Console.WriteLine("the days: {0}, task: {1}, level: {2}, at hour: {3}", ag.dDay, ag.nName, ag.pPriority, ag.hHour);
               }
           }
           else
           {
               Console.WriteLine("No tasks");
           }

               
           
           
          
           
    
             
           Console.ReadLine();
        }
    }
}
