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
            //Arrage
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Beggins"
            };
            string expected = "Beggins, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmptyTest()
        {
            //Arrage
            Customer customer = new Customer
            {
                LastName = "Beggins"
            };
            string expected = "Beggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmptyTest()
        {
            //Arrage
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount+=1;

            var c2 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //act

            //assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidValuesValidateTest()
        {
            //arange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@gmail.com"
            };

            var expected = true;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidValuesValidateTest()
        {
            //arange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@gmail.com"
            };

            var expected = false;

            //act
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
