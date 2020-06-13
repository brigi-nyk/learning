using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    class Rose : IFlower
    {
        #region Properties
        public int Price { get; private set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Create a new instance of Rose.
        /// </summary>
        public Rose(): base()
        {
            DefinePrice();
        }

        /// <summary>
        /// Define the value for the Price.
        /// </summary>
        public void DefinePrice()
        {
            Price = 10;
        }

        #endregion Public Methods
    }
}
