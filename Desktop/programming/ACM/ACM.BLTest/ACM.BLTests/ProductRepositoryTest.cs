
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {

                CurrentPrice = 1.99m,
                ProductDescription = "Classic Mother's day card including personal message",
                ProductName = "Classic Mother's day card."
            };
        

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductID, actual.ProductID);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);


        }
    }
}

