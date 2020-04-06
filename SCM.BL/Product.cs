using System;
using System.Collections.Generic;

namespace SCM.BL
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;

        }

        public bool Save()
        {
            //code that saves the defined product

            return true;
        }

        public Product Retrieve(int productId)
        {
            // code that retrieves the defined product

            return new Product();
        }

        public List<Product> Retrieve()
        {
            // code that retrieves all products

            return new List<Product>();
        }
    }
}
