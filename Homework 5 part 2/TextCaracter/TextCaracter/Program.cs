using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCaracter
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.getValue());
            Console.ReadLine();
        }
    }
}
