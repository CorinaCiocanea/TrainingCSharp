using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
   class ExternalPackage : Package
    {
        public ExternalPackage(Address recipientAddress, double packageWeight)
        {
            RecipientAddress = recipientAddress;
            weight = packageWeight;

            StandardPrice = 20.0;
            ExtraPrice = 10.0;
            KgLimit = 1.0;
        }        
    }
}
