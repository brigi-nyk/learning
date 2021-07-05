using FlowerShop;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FlowerShopTest
{
    public class FlowerTest
    {
        [Fact]
        public void GetRosePriceTest()
        {
            Flower flower = new Rose(10, 20);
            double totalPrice = flower.Price *flower.Quantity;

            Assert.Equal(200, totalPrice);

        }

        [Fact]
        public void GetGladiolisPriceTest()
        {
            Flower flower = new Gladioli(15, 5);
            double totalPrice = flower.Price * flower.Quantity;

            Assert.Equal(75, totalPrice);

        }

        [Fact]
        public void GetOrchidsPriceTest()
        {
            Flower flower = new Orchid(30,10);
            double totalPrice = flower.Price * flower.Quantity;

            Assert.Equal(300, totalPrice);

        }
    }
}
