using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Gladioli : Flower
    {
        #region Public Methods

        /// <summary>
        /// Create a new instance of Gladioli.
        /// </summary>
        /// <param name="price">Set the price.</param>
        /// <param name="quantity">Set the quantity.</param>
        public Gladioli(double price, int quantity)
            : base(price, quantity)
        {
            Name = "Gladioli";
        }

        #endregion Public Methods
    }
}
