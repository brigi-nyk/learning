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
            IFlower flower = new Rose();
            int count = flower.Price;

            Assert.Equal(10, count);

        }

        [Fact]
        public void GetGladiolisPriceTest()
        {
            IFlower flower = new Gladioli();
            int count = flower.Price;

            Assert.Equal(15, count);

        }

        [Fact]
        public void GetOrchidsPriceTest()
        {
            IFlower flower = new Orchid();
            int count = flower.Price;

            Assert.Equal(30, count);

        }
    }
}
