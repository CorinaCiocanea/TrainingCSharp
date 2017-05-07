using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria
{
    class Square : Form
    {
        string type;
        double side;

        public Square(string type, double side)
        {
            this.type = type;
            this.side = side;
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
            return side * side;
        }
    }
}
