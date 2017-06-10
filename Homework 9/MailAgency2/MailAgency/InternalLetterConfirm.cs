using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
    class InternalLetterConfirm : Letter
    {
        public InternalLetterConfirm(Address recipientAddress)
        {
            RecipientAddress = recipientAddress;
            Price = 10;
        }
    }
}
