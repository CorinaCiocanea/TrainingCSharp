using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Agend
{
    class Program
    {
        static void Main(string[] args)
        {

            Agenda agenda = new Agenda();
            agenda.Read();
            agenda.Print();
            //ad.inserare2();
            //ad.afisare2();


            Console.ReadLine();
        }
    }
}
