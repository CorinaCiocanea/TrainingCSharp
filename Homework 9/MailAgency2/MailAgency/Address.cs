using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
  public class Address
    {

        string name;
        string county;
        string locality;
        string street;
        string zipCode;

        public Address(string name, string county, string locality, string street, string zipCode)
        {
            this.name = name;
            this.county = county;
            this.locality = locality;
            this.street = street;
            this.zipCode = zipCode;
        }
        
         
        
        public override string ToString()
        {
            return string.Format("Name: {0} | Recipient Address: {1}, {2}, {3}, {4}", name, county, locality, street, zipCode);
        }
    }
}
