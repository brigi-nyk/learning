using System;

namespace FlowerShop
{
    internal class BigBouquet : Bouquet
    {
        #region Members

        Gladioli gladioli;
        Orchid orchid;

        public int GladiolisQuantity { get; private set; }
        public int OrchidQuantity { get; private set; }

        #endregion Members

        #region Methods

        /// <summary>
        /// Create an instance of BigBouquets.
        /// </summary>
        public BigBouquet() : base() {
            gladioli = new Gladioli();
            orchid = new Orchid();
        }

        /// <summary>
        /// Define the components of the bouquet.
        /// </summary>
        protected override void DefineBouquet() 
        {
            RoseQuantity = 9;
            GladiolisQuantity = 10;
            OrchidQuantity = 3;
        }

        /// <summary>
        /// Calculate the price of the bouquet.
        /// </summary>
        /// <returns>Returns the price in int.</returns>
        internal override int CalcuatePrice()
        {
            int price = base.CalcuatePrice();

            price += GladiolisQuantity * gladioli.Price + OrchidQuantity * orchid.Price;

            return price;
        }

        /// <summary>
        /// Gets the total quantity of the gladiolis from the bouquets.
        /// </summary>
        /// <param name="noBouquets">Number of bouquets.</param>
        /// <returns>Returns the total number of gladiolis.</returns>
        internal int GetTotalQuantityGladiolis(int noBouquets)
        {
            return GladiolisQuantity * noBouquets;
        }

        /// <summary>
        /// Gets the total quantity of the orchids from the bouquets.
        /// </summary>
        /// <param name="noBouquets">Number of bouquets.</param>
        /// <returns>Returns the total number of orchids.</returns>
        internal int GetTotalQuantityOrchids(int noBouquets)
        {
            return OrchidQuantity * noBouquets;
        }

        #endregion Methods
    }
}