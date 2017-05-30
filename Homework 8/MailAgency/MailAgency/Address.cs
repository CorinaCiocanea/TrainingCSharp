using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAgency
{
  public class Address
    {
        private string name;
        private string county;
        private string locality;
        private string street;
        private int codepostal;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }
        public string Locality
        {
            get
            {
                return locality;
            }
            set
            {
                locality = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int CodePostal
        {
            get
            {
                return codepostal;
            }
            set
            {
                codepostal = value;
            }
        }
    }
}
