using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arange
            var customerrepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //act
            var actual = customerrepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobiton",
                        State = "Shire",
                        Country = "Midle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Midle Earth",
                        PostalCode = "146"
                    }
                }
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i=0;i<1;i++)
            {
                Assert.AreEqual(expected.Addresses[i].AddressType, actual.Addresses[i].AddressType);
                Assert.AreEqual(expected.Addresses[i].StreetLine1, actual.Addresses[i].StreetLine1);
                Assert.AreEqual(expected.Addresses[i].State, actual.Addresses[i].State);
                Assert.AreEqual(expected.Addresses[i].City, actual.Addresses[i].City);
                Assert.AreEqual(expected.Addresses[i].Country, actual.Addresses[i].Country);
                Assert.AreEqual(expected.Addresses[i].PostalCode, actual.Addresses[i].PostalCode);
            }




        }

    }
}
