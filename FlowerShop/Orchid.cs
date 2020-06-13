using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Orchid : IFlower
    {
        #region Properties

        public int Price { get; private set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Create a new instance of Orchid
        /// </summary>
        public Orchid() : base()
        {
            DefinePrice();
        }

        /// <summary>
        /// Define the value for the Price.
        /// </summary>
        public void DefinePrice()
        {
            Price = 30;
        }

        #endregion Public Methods
    }
}
