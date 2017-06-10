using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
    class Telegram : PostalMessage
    {
        const double StandardPrice = 10.0;
        const double ExtraPrice = 1.0;
        string message;

        public Telegram(Address recipientAddress, string message)
        {
            RecipientAddress = recipientAddress;
            this.message = message;
        }

        public override double GetPrice()
        {
            if (string.IsNullOrEmpty(message))
                return 0;

            if (message.Length <= 100)
                return StandardPrice;
            else
            {
                double price = StandardPrice;

                string extraMessage = message.Substring(100);
                string[] extraWords = extraMessage.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' });

                price += extraWords.Length * ExtraPrice;

                return price;
            }
        }
    }
}
