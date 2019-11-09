using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        //Constructor chaining - one constructor needs to call another constructor
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        //the list does not have a good default value 
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";

                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        //public string Log() 
        //{
        //    var logString = CustomerId + ": " + 
        //        FullName + " " + "Email: " + 
        //        EmailAddress + "Status: " + 
        //        EntityState.ToString();

        //    return logString;
        //}

        public string Log() => 
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

    }
}
