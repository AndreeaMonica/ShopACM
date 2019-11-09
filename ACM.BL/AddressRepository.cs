using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository 
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AdressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.Country = "MiddleEarth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            var address = new Address(1)
            {
                AdressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AdressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            //Code that saves the defined product
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //Called an Insert Stored Procedure
                    }
                    else
                    {
                        //Called an Update Stores Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}
