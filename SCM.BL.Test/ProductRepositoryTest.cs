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
        [Fact]
        public void SaveTestValid()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.True(actual);
        }
        [Fact]
        public void SaveTestMissingPrice()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // -- Act
            var actual = productRepository.Save(updatedProduct);

            // -- Assert
            Assert.False(actual);
        }


    }
}
