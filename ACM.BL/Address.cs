using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
                
        }
        public Address(int adressId)
        {
            this.AdressId = adressId;
        }

        public int AdressId { get; set; }
        public int AdressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        
        public bool Validate()
        {
            var isValide = true;

            if (PostalCode == null) isValide = false;

            return isValide;
        }
    }
}
