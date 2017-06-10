using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
    class InternalLetter : Letter
    {
         public InternalLetter(Address recipientAddress)
        {            
            RecipientAddress = recipientAddress;
            Price = 3;
        }
    }
}
