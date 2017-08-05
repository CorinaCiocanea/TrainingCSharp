using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aria
{
   public abstract class Form
    {
       public abstract string Type { get; }
       public abstract double GetArea();
    }
}
