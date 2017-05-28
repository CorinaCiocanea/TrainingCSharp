using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace FunctionWrite
{

    class Program
    {
        static FileStream fs;
        static StreamWriter sw;
        public delegate void WriteString(string str);

        public static void WriteAllStrings(WriteString deleg)
        {
            deleg("Heloo");
        }
        //public static void WriteAllStrings(WriteString deleg, List<string> list)
        //{


        //    foreach (string str in list)
        //    {
        //        list.Add("heloo");
        //        deleg(str);
        //    }
        //}

        public static void WriteToConsole(string str)
        {
            Console.WriteLine("The string is: {0}", str);
        }

        public static void WriteToFile(string str)
        {
            fs = new FileStream("D:\\DRAGOS\\exemple c#\\Homework 8\\FunctionWrite\\input.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        
        static void Main(string[] args)
        {
            WriteString write = new WriteString(WriteToConsole);
            WriteString write2 = new WriteString(WriteToFile);
            WriteAllStrings(write);
            WriteAllStrings(write2);
            WriteString(sel => sel.Select(WriteToConsole));
               
            //WriteString stri = str => WriteToConsole;
            
            //Fwrite file = new Fwrite();

            Console.ReadLine();
           
            
        }
    }     
}
