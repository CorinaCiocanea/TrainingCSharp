﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria
{
    class Circle : Form
    {
        string type;
        double radius;
        public Circle(double radius)
        {
            this.type = "circle";
            this.radius = radius;
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
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
