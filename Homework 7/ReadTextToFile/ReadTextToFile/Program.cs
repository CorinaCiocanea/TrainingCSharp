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
            foreach (string line in allLines)
            {
                string line1;
                if (line[line.Length - 1] == '"')
                {
                    line1 = line.Substring(0, line.Length - 1).TrimEnd() + "\"";
                }
                else
                {
                    line1 = line.TrimEnd();
                }

                StreamWriter sw = File.AppendText(OutputfileName);
                sw.WriteLine("Line {0}: {1}", linenumber, line);
                sw.Close();

            }
               
           
          
            Console.ReadLine();

        }
  

    }
}
