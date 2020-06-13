using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        private string _productName;

        public int ProductId { get; private set; }
        public string ProductName { get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        

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
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;

            return isValid;
        }

        public override string ToString() => ProductName;
        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} State: {EntityState}";
    }
}
