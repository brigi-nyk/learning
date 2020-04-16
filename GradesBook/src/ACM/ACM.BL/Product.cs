using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        
        /// <summary>
        /// Validate the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;

            return isValid;
        }
    }
}
