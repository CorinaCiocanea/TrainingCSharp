using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
    abstract class PostalMessage : IPostalMessage
    {
        internal Address RecipientAddress;
        public abstract double GetPrice();
    }
}
