using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
    public class ExampleThrow
    {
        public string Method2()
        {
            try 
            {
                ErrorMethod2();
                return "Method2 called";
               
            }
            catch(Exception ex) 
            {
                throw;
            
            }
        }

        public void ErrorMethod2()
        {
            throw new TimeoutException();
        }
    }
}
