using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerShop
{
    public class BigBouquet : Bouquet
    {
        #region Methods

        /// <summary>
        /// Create an instance of BigBouquets.
        /// </summary>
        /// <param name="flowers">The list of flowers that creates the bouquet.</param>
        /// <param name="quantity">Number of bouquets.</param>
        public BigBouquet(List<Flower> flowers, int quantity)
            : base(flowers, quantity) { }

        #endregion Methods
    }
}