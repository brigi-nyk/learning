using System;
using System.Collections.Generic;

namespace FlowerShop
{
    public class MediumBouquet:Bouquet
    {
        #region Methods

        /// <summary>
        /// Create an instance of MediumBouquet.
        /// </summary>
        /// <param name="flowers">The list of flowers that creates the bouquet.</param>
        /// <param name="quantity">Number of bouquets.</param>
        public MediumBouquet(List<Flower> flowers, int quantity)
            : base(flowers, quantity) { }

        #endregion Methods
    }
}