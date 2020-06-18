using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public enum Interval
    {
        None,
        Day,
        Week,
        Month,
        Year
    }

    public class Report
    {
        #region Members

        public BigBouquet bigBouquet;
        public MediumBouquet mediumBouquet;
        public SmallBouquet smallBouquet;
        public Rose rose;
        public Gladioli gladioli;
        public Orchid orchid;

        public int Multiplier { get; set; }
        public Interval FirstInterval { get; set; }

        #endregion Members         

        #region Public Methods

        /// <summary>
        /// Create an instance of the Report.
        /// </summary>
        /// <param name="interval">The first interval.</param>
        /// <param name="big">The big bouquet object.</param>
        /// <param name="medium">The medium bouquet object.</param>
        /// <param name="small">The small bouquet object.</param>
        /// <param name="rose">The Rose object.</param>
        /// <param name="gladioli">The Gladioli object.</param>
        /// <param name="orchid">The Orchid object.</param>
        public Report(Interval interval, BigBouquet big, MediumBouquet medium,
            SmallBouquet small, Rose rose, Gladioli gladioli, Orchid orchid)
        {
            FirstInterval = interval;
            bigBouquet = new BigBouquet(big.Flowers, big.Quantity);
            mediumBouquet = new MediumBouquet(medium.Flowers, medium.Quantity);
            smallBouquet = new SmallBouquet(small.Flowers, small.Quantity);
            this.rose = new Rose(rose.Price, rose.Quantity);
            this.gladioli = new Gladioli(gladioli.Price, gladioli.Quantity);
            this.orchid = new Orchid(orchid.Price, orchid.Quantity);
        }

        /// <summary>
        /// Create the report based on the interval specified.
        /// </summary>
        /// <param name="interval">The interval.</param>
        public void CreateReport(Interval interval)
        {
            Multiplier = SetMultiplierFromInterval(interval);

            Console.WriteLine("In one " + interval + " we have sold:\n");

            WriteReportForBouquets("Big", bigBouquet);
            WriteReportForBouquets("Medium", mediumBouquet);
            WriteReportForBouquets("Small", smallBouquet);

            WriteReportForFlowers("Roses", rose);
            WriteReportForFlowers("Gladiolis", gladioli);
            WriteReportForFlowers("Orchids", orchid);

        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Create the output for the bouquets per type.
        /// </summary>
        /// <param name="bouquetName">Name of bouquet type.</param>
        /// <param name="bouquet">The bouquet object.</param>
        private void WriteReportForBouquets(string bouquetName, Bouquet bouquet)
        {
            Console.WriteLine(bouquetName + " Bouquets: \n Price of one: " + bouquet.ComputePrice());
            Console.WriteLine(" Total " + bouquetName + " Bouquets: " + (bouquet.Quantity * Multiplier));
            Console.WriteLine(" Total price: " + (bouquet.ComputePrice() * bouquet.Quantity * Multiplier) + "\n");
        }

        /// <summary>
        /// Create the output for the flowers per type.
        /// </summary>
        /// <param name="flowerName">Name of flower type.</param>
        /// <param name="flower">The flower object.</param>
        private void WriteReportForFlowers(string flowerName, Flower flower)
        {
            int flowers = Multiplier * flower.Quantity;
            int totalFlowers = Multiplier * (bigBouquet.GetTotalQuantityOfFlower(flower.Name)
                + mediumBouquet.GetTotalQuantityOfFlower(flower.Name)
                +smallBouquet.GetTotalQuantityOfFlower(flower.Name));

            Console.WriteLine(flowerName + ": \n Sold per pieces: " + flowers);
            Console.WriteLine(" Price: " + flower.Price * flowers);
            Console.WriteLine(" Total " + flowerName + " sold: " + totalFlowers + "\n");
        }

        /// <summary>
        /// Calculate how many times the first interval is repeated in the requested interval.
        /// </summary>
        /// <param name="interval">Requested interval.</param>
        /// <returns>Returns the multiplier.</returns>
        private int SetMultiplierFromInterval(Interval interval)
        {
            int result = 0;

            if (interval == Interval.Week)
            {
                result = DayOfWeek.Saturday - DayOfWeek.Monday;
            }
            else if (interval == Interval.Month)
            {
                if (FirstInterval == Interval.Day)
                {
                    result = 25;
                }
                else if (FirstInterval == Interval.Week)
                {
                    result = 4;
                }
            }
            else if (interval == Interval.Year)
            {
                if (FirstInterval == Interval.Day)
                {
                    result = 300;
                }
                else if (FirstInterval == Interval.Week)
                {
                    result = 52;
                }
                else if (FirstInterval == Interval.Month)
                {
                    result = 12;
                }
            }

            return result;
        }

        #endregion Private Methods
    }
}
