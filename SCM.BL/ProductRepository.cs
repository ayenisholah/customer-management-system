using System;
namespace SCM.BL
{
    public class ProductRepository
    {
        public ProductRepository()
        {
        }

        public Product Retrieve(int productId)
        {
            // create the instance of the new product class
            // pass in the request Id

            Product product = new Product();

            // code that retrieves the defined product

            // temporary hard-coded values to return a populated product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 bright Yellow Mini sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save()
        {
            // code that retrieves saved product

            return true;
        }
    }
}
