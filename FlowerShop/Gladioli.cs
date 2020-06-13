using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    class Gladioli : IFlower
    {
        #region Properties 
        public int Price { get; private set; }

        #endregion  Properties

        #region Public Methods

        /// <summary>
        /// Create a new instance of Gladioli.
        /// </summary>
        public Gladioli() : base()
        {
            DefinePrice();
        }

        /// <summary>
        /// Define the value for the Price.
        /// </summary>
        public void DefinePrice()
        {
            Price = 15;
        }

        #endregion Public Methods
    }
}
