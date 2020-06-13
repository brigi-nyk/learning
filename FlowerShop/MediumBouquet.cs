using System;

namespace FlowerShop
{
    public class MediumBouquet:Bouquet
    {
        #region Members

        IFlower gladioli;
        public int GladiolisQuantity { get; private set; }

        #endregion Members

        #region Methods

        /// <summary>
        /// Create an instance of MediumBouquets.
        /// </summary>
        public MediumBouquet() : base() 
        {
            gladioli = new Gladioli();
        }

        /// <summary>
        /// Define the components of the bouquet.
        /// </summary>
        protected override void DefineBouquet()
        {
            RoseQuantity = 6;
            GladiolisQuantity = 5;
        }

        /// <summary>
        /// Calculate the price of the bouquet.
        /// </summary>
        /// <returns>Returns the price in int.</returns>
        public override int CalcuatePrice()
        {
            int price = base.CalcuatePrice();
            price += GladiolisQuantity * gladioli.Price;
            return price;
        }

        /// <summary>
        /// Gets the total quantity of the gladiolis from the bouquets.
        /// </summary>
        /// <param name="noBouquets">Number of bouquets.</param>
        /// <returns>Returns the total number of gladiolis.</returns>
        public int GetTotalQuantityGladiolis(int noBouquets)
        {
            return GladiolisQuantity * noBouquets;
        }

        #endregion Methods
    }
}