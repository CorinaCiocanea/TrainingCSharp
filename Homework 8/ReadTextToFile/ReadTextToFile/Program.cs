using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ReadTextToFile
{
   public class Program
    {
        private static Regex regexWhitespace = new Regex("\n\\s+");
        static void Main(string[] args)
        {
            string InputfileName = "input.txt";
            string OutputfileName = "output.txt";
            int linenumber = 0;
            //StreamWriter writer = null;
            //writer = new StreamWriter(OutputfileName);
           //private static Regex regexWhitespace = new Regex("\n\\s+");

             //using (var InputFile = File.OpenRead("input.txt"))
             //using (var OutputFile = File.OpenWrite("output.txt"))
             //{
             //    BinaryReader reader = new BinaryReader(InputFile);
             //    BinaryWriter writer = new BinaryWriter(OutputFile);

             //    byte[] buffer = new Byte[1024];
             //    int bytesRead;

             //    while ((bytesRead = InputFile.Read(buffer, 0, 1024)) > 0)
             //    {
             //        OutputFile.Write(buffer, 0, bytesRead);
             //    }
             //}
            string[] allLines = File.ReadAllLines(InputfileName);
    
            foreach (string line in allLines)
            {
               
                char[] upper = line.ToCharArray();
                upper[1] = char.ToUpper(upper[1]);
                Console.WriteLine(upper);

                StreamWriter sw = File.AppendText(OutputfileName);
                sw.WriteLine(upper);
                sw.Close();
            }
          
            
            foreach (string line in allLines)
            {
                linenumber++;
                Console.WriteLine("Line {0}: {1}", linenumber, line);

                StreamWriter sw = File.AppendText(OutputfileName);
                sw.WriteLine("Line {0}: {1}", linenumber, line);
                sw.Close();
                
            }

            //foreach (string line in allLines)
            //{
            //    
            //    string line1;
            //    line1 = line.Replace("\t", " ");
            //    line1 = line.Replace(" ", " ");
            //    line1 = line.TrimEnd();
            //   line1 = line.Replace(" ", "");

            //    Console.WriteLine(line1);
            //} 
               
            StringBuilder buffer = new StringBuilder();

            //foreach (string line in allLines)
            //{
            //    StreamWriter writer = null;
            //    writer = new StreamWriter(OutputfileName);
            //   // StreamWriter sw = new StreamWriter(OutputfileName);
            //    //StringBuilder buffer = new StringBuilder();
            //    string str = buffer.ToString();
            //    string trimmed = str.Trim();
            //    string textOnly = regexWhitespace.Replace(trimmed, "/n");
            //    if (!string.IsNullOrEmpty(textOnly))
            //    {
            //        writer.WriteLine(textOnly);
            //    }
                //StreamWriter sw = File.AppendText(OutputfileName);
                //sw.WriteLine(textOnly);
                //sw.Close();
           // }

           
            Console.ReadLine();

        }
  
    }
}
