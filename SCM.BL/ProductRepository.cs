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
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        public bool Save(Product product)
        {
            // code that retrieves saved product
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // call an insert store procedure
                    }
                    else
                    {
                        // call an update store procedure
                    }
                }
                else
                {
                    success = true;
                }
            }

            return success;
        }
    }
}
