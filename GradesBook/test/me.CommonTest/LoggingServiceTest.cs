using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace me.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //arrange
            var changeItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Bilbo",
                LastName = "Baggins",
                Addresses = null
            };
            changeItems.Add(customer);

            var prod = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake",
                CurrentPrice = 6M
            };
            changeItems.Add(prod);

            //act
            LoggingService.WriteToFile(changeItems);


        }
    }
}
