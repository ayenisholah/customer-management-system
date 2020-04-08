using System;
using System.Collections.Generic;

namespace SCM.BL
{
    public class Product : EntityBase
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

        public override string ToString() => ProductName;

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;

        }

        public List<Product> Retrieve()
        {
            // code that retrieves all products

            return new List<Product>();
        }
    }
}
