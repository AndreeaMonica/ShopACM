using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //Temporary hard-coded values to return 
            //a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).
                                                ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            //Code that saves the defined product
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
