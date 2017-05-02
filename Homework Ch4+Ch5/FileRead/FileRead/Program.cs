using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileRead
{
    class Program
    {
       
        static void Main(string[] args)
        
            //string fileName = "ExempluFormeGeometrice.txt";
        {
            ReadFromFile();
            //CountLines();
        }
        public static void ReadFromFile()
        {
            System.Console.WriteLine("Give file path:");
            //string fileName = System.Console.ReadLine();
            using (StreamReader reader = File.OpenText(@"D:\DRAGOS\exemple c#\FileRead\ExempluFormeGeometrice.txt"))
            {
                string fileName = null;
                // count = 0;

               while ((fileName = reader.ReadLine()) != null)
                {
                    //string line = reader.ReadLine();
                    //var values = fileName.Split(',');
                    //var lines = fileName.Split(new char[] { '\n' });
                    //var count = lines.Count;
                    
                    Console.WriteLine("{0}", fileName);

                 }
               int count = 0;
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                   count++;
                   Console.WriteLine("{0}", count);
                   Console.ReadLine();
               }
               //String line = reader.ReadToEnd();
               //Console.WriteLine(line);
                //Console.WriteLine("Table Printed.");
                //Console.ReadLine();
              }
            Console.ReadLine();
        }
        //public static void CountLines(string filePath)
        
        
        
    }
       

 

}

    

