using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Agend
{
    class Afis
    {
        Info [] vect = new Info[20];
        string str;
        int n;
        public Afis()
        {
            Console.Write("Input the size of list : ");
            n = Convert.ToInt32(Console.ReadLine());
           for(int i = 0; i < n; i++)
               vect[i] = new Info();
        }
        public void inserare2()
        {
            for (int i = 0; i < n; i++)
            {
                vect[i].inserare();
                
            }
          
        }
        public void afisare2()
        {
          for (int i = 0; i < 2; i++)
            {
                vect[i].afisare();
            }
        }



    }
}
