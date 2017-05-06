using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FibonnaciIE
{
    public class Fibo : IEnumerable
    {
        private readonly int sequenceSize;

        public Fibo(int sequenceSize)
        {

            this.sequenceSize = sequenceSize;
        }

        public IEnumerator GetEnumerator()
        {
            int n1 = 0;
            int n2 = 1;
            int count = 0;

            while (count <= sequenceSize)
            {
                var n1Temp = n1;
                n1 = n2;
                n2 = n1Temp + n2;
                ++count;

                yield return n2 - n1;
            }
        }
        
    }
}
