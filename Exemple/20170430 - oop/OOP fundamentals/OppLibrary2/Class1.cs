using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppLibrary2
{
    public class ProtectedInternal
    {
        protected internal int i;
        protected int j;
        internal int a;

        public int MyI
        {
            get
            {
                return i;
            }
        }

        public int J
        {
            get
            {
                return j;
            }

            set
            {
                j = value;
            }
        }


        public int MyAge
        {
            get; private set;
        }


        public void MyMethod()
        {
            i = 7;
            MyAge = 12;
        }
    }

    public class DerivedProtectedInternal : ProtectedInternal
    {
        public void MyMethod()
        {
            i = 7;
            j = 3;
        }
    }

    public class NotDerivedProtectedInternal
    {
        public void MyMethod()
        {
            ProtectedInternal instance = new ProtectedInternal();
            instance.i = 5;
            instance.a = 5;
            //instance.j = 7;
          //  instance.MyAge = 2;

            System.Console.WriteLine(instance.MyAge);
                
        }
    }
}
