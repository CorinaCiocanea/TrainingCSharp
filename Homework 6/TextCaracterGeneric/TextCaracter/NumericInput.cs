using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaracter
{
    class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(Char.IsDigit(c))
           
            {
                base.Add(c);
            }
            
        }
    }
}
