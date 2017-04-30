using System;

namespace OopLibrary
{
    public class ProtectedInternal
    {
        protected internal int i;
        protected int j;

        public void MyMethod()
        {
            i = 7;
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
}
