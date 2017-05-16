using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaracter
{
    class TextGeneric<T> : List<T>
    {
        public List<T> list = new List<T>();
       
       public void AddInput<T>(this List<T> input)
           
        {
            foreach (var item in input)
            {
                input.Add(item);
            }
        }
    }
}
