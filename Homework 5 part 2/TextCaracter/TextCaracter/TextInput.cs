using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaracter
{
   public class TextInput
    {

         string value = "";
        public virtual void Add(char c)
        {
            this.value = this.value + c ;
        }
        public string getValue()
        {
            return this.value;
        }
    }
}
