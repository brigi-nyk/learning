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
        #region Attributes 

        readonly BigBouquet bigBouquet;
        readonly MediumBouquet mediumBouquet;
        readonly SmallBouquet smallBouquet;

        #endregion Attributes

        #region Properties

        public int NoBigBouquet { get; set; }
        public int NoMediumBouquet { get; set; }
        public int NoSmallBouquet { get; set; }
        public int NoRoses { get; set; }
        public int NoGladiolis { get; set; }
        public int NoOrchids { get; set; }
        public Interval FirstInterval { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Create an instance of the report.
        /// </summary>
        /// <param name="interval">First interval.</param>
        /// <param name="noBigBouquets">Number of big bouquets sold.</param>
        /// <param name="noMediumBouquets">Number of medium bouquets sold.</param>
        /// <param name="noSmallBouquets">Number of small bouquets sold.</param>
        /// <param name="noRoses">Number of roses sold by piece.</param>
        /// <param name="noGladiolis">Number of gladiolis sold by piece.</param>
        /// <param name="noOrchids">Number of orchids sold by piece.</param>
        public Report(Interval interval, int noBigBouquets, int noMediumBouquets, int noSmallBouquets,
            int noRoses, int noGladiolis, int noOrchids)
        {
            FirstInterval = interval;
            NoBigBouquet = noBigBouquets;
            NoMediumBouquet = noMediumBouquets;
            NoSmallBouquet = noSmallBouquets;
            NoRoses = noRoses;
            NoGladiolis = noGladiolis;
            NoOrchids = noOrchids;
            bigBouquet = new BigBouquet();
            mediumBouquet = new MediumBouquet();
            smallBouquet = new SmallBouquet();
        }

        /// <summary>
        /// Create the report based on the interval specified.
        /// </summary>
        /// <param name="interval">The interval.</param>
        public void CreateReport(Interval interval)
        {
            int multiplier = CalculateMultiplierFromInterval(interval);

            Console.WriteLine("In one " + interval + " we have sold:\n");

            WriteReportForBouquets("Big", NoBigBouquet, bigBouquet.CalcuatePrice(), multiplier);
            WriteReportForBouquets("Medium", NoMediumBouquet, mediumBouquet.CalcuatePrice(), multiplier);
            WriteReportForBouquets("Small", NoSmallBouquet, smallBouquet.CalcuatePrice(), multiplier);

            WriteReportForFlowers("Roses", new Rose(), NoRoses, multiplier, CalculateTotalRoses(multiplier));
            WriteReportForFlowers("Gladiolis", new Gladioli(), NoGladiolis, multiplier, CalculateTotalGladiolis(multiplier));
            WriteReportForFlowers("Orchids", new Orchid(), NoOrchids, multiplier, CalculateTotalOrchids(multiplier));

        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Create the output for the bouquets per type.
        /// </summary>
        /// <param name="bouquetType">Name of bouquet type.</param>
        /// <param name="noBouquets">Number of bouquets.</param>
        /// <param name="price">Price of one bouquet.</param>
        /// <param name="multiplier">Number of times the first interval is repeated in the requested interval.</param>
        private void WriteReportForBouquets(string bouquetType, int noBouquets, int price, int multiplier)
        {
            Console.WriteLine(bouquetType + " Bouquets: \nPrice of one: " + price);
            Console.WriteLine(" Total " + bouquetType + " Bouquets: " + (noBouquets * multiplier));
            Console.WriteLine(" Total price: " + price * noBouquets * multiplier+ "\n");
        }

        /// <summary>
        /// Create the output for the flowers per type.
        /// </summary>
        /// <param name="flowerType">Name of flower type.</param>
        /// <param name="flower">The flower object.</param>
        /// <param name="noFlowers">Number of flowers sold by piece</param>
        /// <param name="multiplier">Number of times the first interval is repeated in the requested interval.</param>
        /// <param name="totalFlowers">Number of total flowers sold.</param>
        private void WriteReportForFlowers(string flowerType, IFlower flower, int noFlowers, int multiplier, int totalFlowers)
        {
            int flowers = multiplier * noFlowers;
            Console.WriteLine(flowerType + ": \nSold per pieces: " + flowers);
            Console.WriteLine(" Price: " + flower.Price * flowers);
            Console.WriteLine(" Total " + flowerType + " sold: " + totalFlowers + "\n");
        }

        /// <summary>
        /// Calculate how many times the first interval is repeated in the requested interval.
        /// </summary>
        /// <param name="interval">Requested interval.</param>
        /// <returns>Returns the multiplier.</returns>
        private int CalculateMultiplierFromInterval(Interval interval)
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

        /// <summary>
        /// Calculates how many roses were sold by piece and by bouquets alltogether.
        /// </summary>
        /// <param name="multiplier">Number of times the first interval is repeated in the requested interval.</param>
        /// <returns>Returns the totat number of roses.</returns>
        private int CalculateTotalRoses(int multiplier)
        {
            int count = multiplier * NoRoses;

            count += bigBouquet.GetTotalQuantityRoses(NoBigBouquet * multiplier);
            count += mediumBouquet.GetTotalQuantityRoses(NoMediumBouquet * multiplier);
            count += smallBouquet.GetTotalQuantityRoses(NoSmallBouquet * multiplier);

            return count;
        }

        /// <summary>
        /// Calculates how many gladiolis were sold by piece and by bouquets alltogether.
        /// </summary>
        /// <param name="multiplier">Number of times the first interval is repeated in the requested interval.</param>
        /// <returns>Returns the totat number of gladiolis.</returns>
        private int CalculateTotalGladiolis(int multiplier)
        {
            int count = multiplier * NoGladiolis;

            count += bigBouquet.GetTotalQuantityGladiolis(NoBigBouquet * multiplier);
            count += mediumBouquet.GetTotalQuantityGladiolis(NoMediumBouquet * multiplier);

            return count;
        }

        /// <summary>
        /// Calculates how many orchids were sold by piece and by bouquets alltogether.
        /// </summary>
        /// <param name="multiplier">Number of times the first interval is repeated in the requested interval.</param>
        /// <returns>Returns the totat number of orchids.</returns>
        private int CalculateTotalOrchids(int multiplier)
        {
            int count = multiplier * NoOrchids;

            count += bigBouquet.GetTotalQuantityOrchids(NoBigBouquet * multiplier);

            return count;
        }

        #endregion Private Methods
    }
}
