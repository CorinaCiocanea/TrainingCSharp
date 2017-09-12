using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
   public class ExampleThrowEx
    {
        public string Method3()
        {
            try
            {
                ErrorMethod3();
                return "Method3 called";

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
       
        public void ErrorMethod3()
        {
            throw new TimeoutException();
        }
    }
}
