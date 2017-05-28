using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FunctionWrite
{
    public delegate void WriteString(string str);
   public class Fwrite
    {
      //public delegate void WriteString(string str);
      public FileStream fs;
      public StreamWriter sw;
      
     public int n;
       
      public void WriteAllStrings(WriteString deleg, List<string> list)
      {
         

          foreach (string str in list)
          {
              list.Add("heloo");
              deleg(str);
          }
      }

      public void WriteToConsole(string str)
      {
          Console.WriteLine("The string is: {0}", str);
      }

      public void WriteToFile(string str)
        {
            fs = new FileStream("D:\\DRAGOS\\exemple c#\\Homework 8\\FunctionWrite\\input.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        

    }
}
