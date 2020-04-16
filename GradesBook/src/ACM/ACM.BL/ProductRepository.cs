using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //code that retrieves the defined customer
            Product prod = new Product(productId);

            if (productId ==2 )
            {
                prod.ProductName = "Sunflowers";
                prod.ProductDescription = "Assorted Size Set of 4 Brigth Yellow flowers";
                prod.CurrentPrice = 15.96M;
            }

            return prod;
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            //code that retrieves the defined customer

            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //code that saves teh defined product

            return true;
        }

    }
}
