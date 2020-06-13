using System;

namespace FlowerShop
{
    public class SmallBouquet: Bouquet
    {
        #region Methods

        /// <summary>
        /// Create an instance of SmallBouquet.
        /// </summary>
        public SmallBouquet() : base() { }
        
        /// <summary>
        /// Define the components of the bouquet.
        /// </summary>
        protected override void DefineBouquet()
        {
            RoseQuantity = 5;
        }

        #endregion Methods
    }
}