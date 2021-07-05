using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public abstract class Flower
    {
        #region Properties 
        
        public string Name { get; protected set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        #endregion  Properties

        #region Public Methods

        /// <summary>
        /// Create a new instance of Flower.
        /// </summary>
        /// <param name="price">Define the price of the flower.</param>
        /// <param name="quantity">Define the quantity.</param>
        public Flower(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        #endregion Public Methods
    }
}
