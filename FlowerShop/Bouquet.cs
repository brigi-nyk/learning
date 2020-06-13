using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    abstract class Bouquet
    {
        #region Members

        protected IFlower rose;
        public int RoseQuantity { get; protected set; }
        public int PackingPrice { get; private set; }

        #endregion Memberts

        #region Methods

        /// <summary>
        /// Create instance of an inherited class
        /// </summary>
        protected Bouquet()
        {
            PackingPrice = 2;
            DefineBouquet();
            rose = new Rose();
        }

        /// <summary>
        /// Define each bouquet.
        /// </summary>
        abstract protected void DefineBouquet();

        /// <summary>
        /// Gets the total quantity of the roses from the bouquets.
        /// </summary>
        /// <param name="noBouquets">Number of bouquets.</param>
        /// <returns>Returns the total number of roses.</returns>
        virtual internal int GetTotalQuantityRoses(int noBouquets)
        {
            return RoseQuantity * noBouquets;
        }

        /// <summary>
        /// Calculate the price of the bouquet.
        /// </summary>
        /// <returns>Returns the price in int.</returns>
        virtual internal int CalcuatePrice()
        {
            int price = PackingPrice + (RoseQuantity * rose.Price);
            return price;
        }

        #endregion Methods
    }
}
