using System;
using Xunit;

namespace SCM.BL.Test
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {

                ProductName = "Sunflowers",
                ProductDescription = "Assorted size set of 4 bright Yellow Mini sunflowers",
                CurrentPrice = 15.96M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert

            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
        }
    }
}
