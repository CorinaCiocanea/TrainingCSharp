using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria
{
    class Rectangle : Form
    {
        string type;
        double length;
        double width;

        public Rectangle(string type, double length, double width)
        {
            this.type = type;
            this.length = length;
            this.width = width;
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
            return length * width;
        }
    }
}
