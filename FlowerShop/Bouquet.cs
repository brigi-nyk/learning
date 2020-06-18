using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FlowerShop
{
    public abstract class Bouquet 
    {
        #region Members

        public List<Flower> Flowers { get; private set; } = new List<Flower>();
        public int Quantity { get; private set; }

        #endregion Memberts

        #region Methods

        /// <summary>
        /// Create an instance of a bouquet.
        /// </summary>
        /// <param name="flowers">The list of flowers that creates the bouquet.</param>
        /// <param name="quantity">Number of bouquets.</param>
        public Bouquet(List<Flower> flowers, int quantity)
        {
            Flowers.AddRange(flowers);
            Quantity = quantity;
        }

        /// <summary>
        /// Computes the price of the bouquet by it's flowers.
        /// </summary>
        /// <returns>Returns the price.</returns>
        public double ComputePrice()
        {
            double price = (from flower in Flowers
                            select flower.Price * flower.Quantity).Sum();
                        
            return price + 2;
        }

        /// <summary>
        /// Get the total quantity of a specified flower.
        /// </summary>
        /// <param name="flowerName">The name of flower.</param>
        /// <returns>Returns the quantity.</returns>
        public int GetTotalQuantityOfFlower(string flowerName)
        {
            int result = (from flower in Flowers
                          where (flower.Name == flowerName)
                          select flower.Quantity).Sum();

            return result * Quantity;
        }

        #endregion Methods
    }
}
