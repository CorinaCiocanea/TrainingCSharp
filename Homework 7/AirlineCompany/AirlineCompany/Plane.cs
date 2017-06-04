using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineCompany
{
    class Plane
    {
        private int numberrow;
        private int numberplacerow;

        public int NumberRow
        {
            get
            {
                return numberrow;
            }
            set
            {
                numberrow = value;
            }
        }
        public int NumberPlaceRow
        {
            get 
            {
                return numberplacerow;
            }
            set 
            {
                numberplacerow = value;
            }
        }
    }
}
