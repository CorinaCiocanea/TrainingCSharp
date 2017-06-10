using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
  abstract class Letter : PostalMessage
    {
       public double Price { get; set; }
       public override double GetPrice()
       {
           return Price;
         
       }
    }
}
