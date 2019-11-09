using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var addressRepository = new AddressRepository();
            var expected = new Address(1)
            {
                AdressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                Country = "MiddleEarth",
                PostalCode = "144"
            };

            //--Act
            var actual = addressRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.AdressId,actual.AdressId);
            Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
            Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
            Assert.AreEqual(expected.Country, actual.Country);
            Assert.AreEqual(expected.City, actual.City);
            Assert.AreEqual(expected.PostalCode, actual.PostalCode);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var addressRepository = new AddressRepository();

            var address = new Address(2)
            {
                AdressType = 2,
                StreetLine1 = "Commit",
                StreetLine2 = "BaggEnd",
                City = "Shire",
                Country = "MiddleEarth",
                PostalCode = "413",
                HasChanges = true               
            };

            //--Act
            var actual = addressRepository.Save(address);

            //--Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestInvalid()
        {
            //--Arrange
            var addressRepository = new AddressRepository();

            var address = new Address(2)
            {
                AdressType = 2,
                StreetLine1 = "Commit",
                StreetLine2 = "BaggEnd",
                City = "Shire",
                Country = "MiddleEarth",
                PostalCode = null,
                HasChanges = true
            };

            //--Act
            var actual = addressRepository.Save(address);

            //--Assert
            Assert.AreEqual(false, actual);
        }

    }
}
