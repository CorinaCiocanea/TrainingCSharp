using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
   public class ExampleClass1
    {
       public String Method1()
       {
           try 
           {
             ExampleThrow exClas2 = new ExampleThrow();
               return exClas2.Method2();
           }
           catch (Exception ex)
           {
               Console.WriteLine("-----Stack Trace for the Exception Occurred------");
               Console.WriteLine(ex.StackTrace.ToString());
               Console.WriteLine("-------Method in which Exception Occurred------");
               Console.WriteLine(ex.TargetSite.ToString());  
           
           }
           return "";

       
       }

       public String MethodThrowEx()
       {
           try
           {
               ExampleThrowEx Ex2 = new ExampleThrowEx();
               return Ex2.Method3();
           }
           catch (Exception ex)
           {
               Console.WriteLine("-----Stack Trace for the Exception Occurred------");
               Console.WriteLine(ex.StackTrace.ToString());
               Console.WriteLine("-------Method in which Exception Occurred------");
               Console.WriteLine(ex.TargetSite.ToString());

           }
           return "";
       }
    }
}
