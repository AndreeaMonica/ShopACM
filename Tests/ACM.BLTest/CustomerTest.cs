using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //--Act

            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer()
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //--Act
            string actual = customer.FirstName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var customer1 = new Customer();
            customer1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer2.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer3.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            int expected = 3;

            //--Act

            //--Assert
            Assert.AreEqual(expected, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer()
            {
                LastName = "Bilbo",
                EmailAddress = "bilbo.baggins@gmail.com"

            };

            var actual = true;

            //--Act
            var expected = customer.Validate();

            //--Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ValidateInvalid()
        {
            //--Arrange
            var customer = new Customer()
            {
                EmailAddress = "bilbo.baggins@gmail.com"
            };
            var actual = false;

            //--Act
            var expected = customer.Validate();

            //--Assert
            Assert.AreEqual(actual, expected);
        }





    }
}