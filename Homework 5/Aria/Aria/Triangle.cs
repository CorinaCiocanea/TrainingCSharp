using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria
{
    class Triangle : Form
    {
        string type;
        double bSide;
        double hSide;
        public Triangle(string type, double bSide, double hSide)
        {
            this.type = type;
            this.bSide = bSide;
            this.hSide = bSide;
        }

        public override string Type
        {
            get
            {
                return type;
            }
        }

        public override double GetArea()
        {
            return ((bSide * hSide)/2) ;
            //return 0.5 * bSide * hSide;
        }
    }
}
