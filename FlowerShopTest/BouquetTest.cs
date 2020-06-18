using FlowerShop;
using System;
using System.Collections.Generic;
using Xunit;

namespace FlowerShopTest
{
    public class BouquetTest
    {
        [Fact]
        public void GetTotalQuantityRosesFromBigBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,9),
                new Gladioli(15,10),
                new Orchid(30,3)
            };
            Bouquet bouquet = new BigBouquet(flowers, 20);
            int count = bouquet.GetTotalQuantityOfFlower("Rose");

            Assert.Equal(180, count);

        }
        
        [Fact]
        public void GetTotalQuantityGladiolisFromBigBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,9),
                new Gladioli(15,10),
                new Orchid(30,3)
            };
            BigBouquet bouquet = new BigBouquet(flowers, 20);
            int count = bouquet.GetTotalQuantityOfFlower("Gladioli");

            Assert.Equal(200, count);

        }

        [Fact]
        public void GetTotalQuantityOrchidsFromBigBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,9),
                new Gladioli(15,10),
                new Orchid(30,3)
            };
            BigBouquet bouquet = new BigBouquet(flowers, 20);
            int count = bouquet.GetTotalQuantityOfFlower("Orchid");

            Assert.Equal(60, count);

        }

        [Fact]
        public void GetTotalQuantityRosesFromMediumBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,6),
                new Gladioli(15,5)
            };
            Bouquet bouquet = new MediumBouquet(flowers, 15);
            int count = bouquet.GetTotalQuantityOfFlower("Rose");

            Assert.Equal(90, count);

        }

        [Fact]
        public void GetTotalQuantityGladiolisFromMediumBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,6),
                new Gladioli(15,5)
            };
            Bouquet bouquet = new MediumBouquet(flowers, 15);
            int count = bouquet.GetTotalQuantityOfFlower("Gladioli");

            Assert.Equal(75, count);

        }

        

        [Fact]
        public void GetTotalQuantityRosesFromSmallBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,5) };
            Bouquet bouquet = new SmallBouquet(flowers, 65);
            int count = bouquet.GetTotalQuantityOfFlower("Rose");

            Assert.Equal(325, count);

        }

        [Fact]
        public void ComputePriceBigBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,9),
                new Gladioli(15,10),
                new Orchid(30,3)
            };
            BigBouquet bouquet = new BigBouquet(flowers, 20);
            double price = bouquet.ComputePrice();

            Assert.Equal(332, price);

        }

        [Fact]
        public void ComputePriceMediumBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,6),
                new Gladioli(15,5)
            };
            Bouquet bouquet = new MediumBouquet(flowers, 15);
            double price = bouquet.ComputePrice();

            Assert.Equal(137, price);

        }

        [Fact]
        public void ComputePriceSmallBouquetTest()
        {
            List<Flower> flowers = new List<Flower>()
            {
                new Rose(10,5) };
            Bouquet bouquet = new SmallBouquet(flowers, 65);
            double price = bouquet.ComputePrice();

            Assert.Equal(52, price);

        }
    }
}
