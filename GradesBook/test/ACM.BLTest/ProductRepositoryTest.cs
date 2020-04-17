using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //arrange
            var prodrRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Brigth Yellow flowers",
                CurrentPrice = 15.96M
            };

            //act
            var actual = prodrRepository.Retrieve(2);

            //assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //arrange
            var prodrRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Brigth Yellow flowers",
                CurrentPrice = 18M,
                HasChanges = false
            };

            //act
            var actual = prodrRepository.Save(updateProduct);

            //assert
            Assert.AreEqual(true, actual);
            
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange
            var prodrRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Brigth Yellow flowers",
                CurrentPrice = null,
                HasChanges = true
            };

            //act
            var actual = prodrRepository.Save(updateProduct);

            //assert
            Assert.AreEqual(false, actual);

        }
    }
}
