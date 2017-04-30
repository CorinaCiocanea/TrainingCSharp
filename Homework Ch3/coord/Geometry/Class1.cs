using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Coordinate
    {
        protected int x;
        public int y;

        public void Test()
        {
            x = 7;
        }
    }

    internal class CoordinateDerived : Coordinate
    {
        public void DerivedTest()
        {
            x = 7;
        }
    }

    public class ClassInTheSameAssembly
    {
        public void MyMethod()
        {
            Coordinate c = new Coordinate();
            c.y = 5;
        }
    }
}
