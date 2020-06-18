using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Rose : Flower
    {
        #region Public Methods

        /// <summary>
        /// Create new instance of Rose.
        /// </summary>
        /// <param name="price">Set the price.</param>
        /// <param name="quantity">Set the quantity.</param>
        public Rose(double price, int quantity)
            : base(price, quantity) 
        {
            Name = "Rose";
        }
        #endregion Public Methods
    }
}
