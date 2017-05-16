using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface IPerson
    {
      string Name
        {
            get;
            set;
        }

        long CNP
        {
            get;
            set;

        }
        DateTime DateBirth
        {
            get;
            set;

        }
       
    
    }
}
