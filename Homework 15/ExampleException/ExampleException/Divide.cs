using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
   public class Divide
    {
       public void CalculatedDivide()
       {
           try
           {
               int result = 15 / int.Parse("0");
               Console.WriteLine(result);
           }
           catch (DivideByZeroException e)
           {
               Console.Write(e.Message);
               
           }
       }
    }
}
