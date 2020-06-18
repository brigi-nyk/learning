using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Orchid : Flower
    {

        #region Public Methods

        /// <summary>
        /// Create new instance of Orchid.
        /// </summary>
        /// <param name="price">Set the price.</param>
        /// <param name="quantity">Set the quantity.</param>
        public Orchid(double price, int quantity)
            : base(price, quantity)
        {
            Name = "Orchid";
        }
    }
    #endregion Public Methods
}