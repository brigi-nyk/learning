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

    class Report
    {
        Interval firstInterval;

        #region Properties

        public int NoBigBouquet { get; set; }
        public int NoMediumBouquet { get; set; }
        public int NoSmallBouquet { get; set; }
        public int NoRoses { get; set; }
        public int NoGladiolis { get; set; }
        public int NoOrchids { get; set; }
        public int NoBigBouquetPerMonth { get; set; }
        public int NoMediumBouquetPerMonth { get; set; }
        public int NoSmallBouquetPerMonth { get; set; }
        public int NoRosesPerMonth { get; set; }
        public int NoGladiolisPerMonth { get; set; }
        public int NoOrchidsPerMonth { get; set; }

        #endregion Properties

        public Report(Interval interval, int noBigBouquets, int noMediumBouquets, int noSmallBouquets,
            int noRoses, int noGladiolis, int noOrchids)
        {
            firstInterval = interval;
            NoBigBouquet = noBigBouquets;
            NoMediumBouquet = noMediumBouquets;
            NoSmallBouquet = noSmallBouquets;
            NoRoses = noRoses;
            NoGladiolis = noGladiolis;
            NoOrchids = noOrchids;
        }


        public void CreateReport(Interval interval)
        {
            int multiplier = CalculateMultiplierFromInterval(interval);

            Console.WriteLine("In one " + interval + " we have sold:");

            Console.WriteLine("Big Bouquets: "+ CalculateTotalBigBuquets(multiplier));
            Console.WriteLine("Medium Bouquets: " + CalculateTotalMediumBuquets(multiplier));
            Console.WriteLine("Small Bouquets: " + CalculateTotalSmallBuquets(multiplier));
            Console.WriteLine("Roses: " + CalculateTotalRoses(multiplier));
            Console.WriteLine("Gladiolis: " + CalculateTotalGladiolis(multiplier));
            Console.WriteLine("Ochids: " + CalculateTotalOchids(multiplier));
            

        }

        private int CalculateMultiplierFromInterval(Interval interval)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalBigBuquets(int multiplier)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalMediumBuquets(int multiplier)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalSmallBuquets(int multiplier)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalRoses(int multiplier)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalGladiolis(int multiplier)
        {
            throw new NotImplementedException();
        }

        private string CalculateTotalOchids(int multiplier)
        {
            throw new NotImplementedException();
        }

        
    }
}
