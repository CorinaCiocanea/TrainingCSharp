using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
    class InternalPackage : Package
    {
        public InternalPackage(Address recipientAddress, double packageWeight)
        {
            RecipientAddress = recipientAddress;
            weight = packageWeight;

            StandardPrice = 7.0;
            ExtraPrice = 5.0;
            KgLimit = 1.0;
        }        
    }
}
