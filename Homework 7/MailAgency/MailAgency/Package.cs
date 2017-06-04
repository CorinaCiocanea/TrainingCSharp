using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
   abstract class Package : PostalMessage
    {
        internal double StandardPrice { get; set; }
        internal double ExtraPrice { get; set; }
        internal double KgLimit { get; set; }

        internal double weight;

        public override double GetPrice()
        {
            if (weight <= KgLimit)
                return StandardPrice;
            else
                return StandardPrice + (Math.Ceiling(weight - KgLimit) * ExtraPrice);
        }
    }
}
