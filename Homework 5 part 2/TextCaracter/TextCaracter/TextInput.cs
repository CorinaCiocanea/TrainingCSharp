using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaracter
{
    class TextInput
    {

         string value = "";
        public void Add(char c)
        {
            this.value = this.value + c ;
        }
        public string getValue()
        {
            return this.value;
        }
    }
}
