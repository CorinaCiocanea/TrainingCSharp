using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleException
{
    public class ClassC
    {
        public void C(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
        }
    }
}
