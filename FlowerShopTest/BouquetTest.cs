using FlowerShop;
using System;
using Xunit;

namespace FlowerShopTest
{
    public class BouquetTest
    {
        [Fact]
        public void GetTotalQuantityGladiolisFromBigBouquetTest()
        {
            BigBouquet bouquet = new BigBouquet();
            int count = bouquet.GetTotalQuantityGladiolis(80);

            Assert.Equal(800, count);

        }

        [Fact]
        public void GetTotalQuantityOrchidsFromBigBouquetTest()
        {
            BigBouquet bouquet = new BigBouquet();
            int count = bouquet.GetTotalQuantityOrchids(80);

            Assert.Equal(240, count);

        }

        [Fact]
        public void GetTotalQuantityGladiolisFromMediumBouquetTest()
        {
            MediumBouquet bouquet = new MediumBouquet();
            int count = bouquet.GetTotalQuantityGladiolis(60);

            Assert.Equal(300, count);

        }

        [Fact]
        public void GetTotalQuantityRosesFromBigBouquetTest()
        {
            Bouquet bouquet = new BigBouquet();
            int count = bouquet.GetTotalQuantityRoses(80);

            Assert.Equal(720, count);

        }

        [Fact]
        public void GetTotalQuantityRosesFromMediumBouquetTest()
        {
            Bouquet bouquet = new MediumBouquet();
            int count = bouquet.GetTotalQuantityRoses(60);

            Assert.Equal(360, count);

        }

        [Fact]
        public void GetTotalQuantityRosesFromSmallBouquetTest()
        {
            Bouquet bouquet = new SmallBouquet();
            int count = bouquet.GetTotalQuantityRoses(260);

            Assert.Equal(1300, count);

        }

        [Fact]
        public void CalculatePriceBigBouquetTest()
        {
            Bouquet bouquet = new BigBouquet();
            int count = bouquet.CalcuatePrice();

            Assert.Equal(332, count);

        }

        [Fact]
        public void CalculatePriceMediumBouquetTest()
        {
            Bouquet bouquet = new MediumBouquet();
            int count = bouquet.CalcuatePrice();

            Assert.Equal(137, count);

        }

        [Fact]
        public void CalculatePriceSmallBouquetTest()
        {
            Bouquet bouquet = new SmallBouquet();
            int count = bouquet.CalcuatePrice();

            Assert.Equal(52, count);

        }
    }
}
