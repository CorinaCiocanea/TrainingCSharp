using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaOop
{
    class IdentityFunc : IFunc
    {
        public virtual int GetValue(int x)
        { return x;  }
    }
    class DoubleFunc : IdentityFunc
    {
        public override int GetValue(int x)
        { return 2 * x;  }
    }
    class TripleFunc : DoubleFunc
    {
        public new virtual int GetValue(int x) { return 3 * x; }
    }
    class QuadFunc : TripleFunc
    {
        public override int GetValue(int x) { return 4 * x; }
    }
}
