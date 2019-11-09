using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for CustomerRepository
    /// </summary>
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                         AdressType = 1,
                         StreetLine1 = "Bag End",
                         StreetLine2 = "Bagshot row",
                         City = "Hobbiton",
                         Country = "Middle Earth",
                         PostalCode = "144"
                    },
                    new Address()
                    {
                        AdressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
                }
            };

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AdressType, actual.AddressList[i].AdressType);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
            }
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var customer = new Customer(1)
            {
                EmailAddress = "test",
                FirstName = "Bilbo",
                LastName = "test",

                HasChanges = true
                
            };
            //--Act
            var actual = customerRepository.Save(customer);

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingEmailAddress()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var customer = new Customer(1)
            {
                EmailAddress = null,
                FirstName = "Bilbo",
                LastName = "Baggins",

                HasChanges = true
            };
            //--Act
            var actual = customerRepository.Save(customer);

            //--Assert
            Assert.AreEqual(false, actual);
        }



    }
}
