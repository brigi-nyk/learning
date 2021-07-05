using System;
using System.Collections.Generic;

namespace FlowerShop
{
    internal class Reader
    {

        #region Members

        public double PriceRose { get; set; }
        public double PriceGladioli { get; set; }
        public double PriceOrchid { get; set; }
        public int NoBigBouquets { get; set; }
        public int NoMediumBouquets { get; set; }
        public int NoSmallBouquets { get; set; }
        public int NoRoses { get; set; }
        public int NoGladiolis { get; set; }
        public int NoOrchids { get; set; }

        public Interval FirstInterval { get; set; }
        public Interval RequestedInterval { get; set; }

        public Rose rose;
        public Gladioli gladioli;
        public Orchid orchid;
        public BigBouquet bigBouquet;
        public MediumBouquet mediumBouquet;
        public SmallBouquet smallBouquet;

        #endregion Members

        #region Methods

        /// <summary>
        /// Create instance of the Reader.
        /// </summary>
        public Reader()
        {
            PriceRose = 0;
            PriceGladioli = 0;
            PriceOrchid = 0;
            FirstInterval = Interval.None;
            NoBigBouquets = 0;
            NoMediumBouquets = 0;
            NoSmallBouquets = 0;
            NoRoses = 0;
            NoGladiolis = 0;
            NoOrchids = 0;
            RequestedInterval = Interval.None;
        }

        /// <summary>
        /// Reads all values from the console.
        /// </summary>
        public void ReadAllValues()
        {
            Console.WriteLine("Set the prices for the flowers:");
            PriceRose = ReadPrice("Rose");
            PriceGladioli = ReadPrice("Gladioli");
            PriceOrchid = ReadPrice("Orchid");

            Console.WriteLine("Insert a number that corresponds to an interval and press Enter: ");

            var values = Enum.GetValues(typeof(Interval));
            foreach (var value in values)
            {
                Console.WriteLine(((int)value).ToString() + ": " + value);
            }

            do
            {
                FirstInterval = GetValidIntervalValue(Console.ReadLine());
            } while (FirstInterval == Interval.None);

            Console.WriteLine("Insert a number that corresponds to an interval in order to create a report");
            do
            {
                RequestedInterval = GetValidIntervalValue(Console.ReadLine());

                if (RequestedInterval <= FirstInterval)
                {
                    Console.WriteLine("The interval for the report must be bigger. Please try again!");
                }
            } while (RequestedInterval <= FirstInterval);

            NoBigBouquets = ReadQuantity("BIG bouquets");
            Console.WriteLine("DEFINE big bouquet:");
            ReadFlowerQuantity("for big bouquets");
            bigBouquet = new BigBouquet(GenerateList(), NoBigBouquets);

            NoMediumBouquets = ReadQuantity("MEDIUM bouquets");
            Console.WriteLine("DEFINE medium bouquet: ");
            ReadFlowerQuantity("for medium bouquets");
            mediumBouquet = new MediumBouquet(GenerateList(), NoMediumBouquets);

            NoSmallBouquets = ReadQuantity("SMALL bouquets");
            Console.WriteLine("DEFINE small bouquets: ");
            ReadFlowerQuantity("for small bouquets");
            smallBouquet = new SmallBouquet(GenerateList(), NoSmallBouquets);

            Console.WriteLine("\nInsert number of flowers sold by piece:");
            ReadFlowerQuantity(String.Empty);
            rose = new Rose(PriceRose, NoRoses);
            gladioli = new Gladioli(PriceGladioli, NoGladiolis);
            orchid = new Orchid(PriceOrchid, NoOrchids);

        }

        /// <summary>
        /// Generates the report.
        /// </summary>
        public void GenerateReport()
        {
            Report report = new Report(FirstInterval, bigBouquet, mediumBouquet, 
                smallBouquet, rose, gladioli, orchid);
            report.CreateReport(RequestedInterval);
        }

        #endregion Methods

        #region Private Methods

        /// <summary>
        /// Create the list of flowers for the bouquet.
        /// </summary>
        /// <returns>Returs the list of flowers.</returns>
        private List<Flower> GenerateList()
        {
            List<Flower> flowers = new List<Flower>();

            if (NoRoses > 0)
            {
                flowers.Add(new Rose(PriceRose, NoRoses));
            }

            if (NoGladiolis > 0)
            {
                flowers.Add(new Gladioli(PriceGladioli, NoGladiolis));
            }

            if (NoOrchids > 0)
            {
                flowers.Add(new Orchid(PriceOrchid, NoOrchids));
            }

            return flowers;
        }

        /// <summary>
        /// Reads the quantities of flowers.
        /// </summary>
        /// <param name="bouquetName">The bouquet name for witch are read the quantities.</param>
        private void ReadFlowerQuantity(string bouquetName)
        {
            NoRoses = ReadQuantity("roses " + bouquetName);
            NoGladiolis = ReadQuantity("gladiolis " + bouquetName);
            NoOrchids = ReadQuantity("orchids " + bouquetName);
        }

        /// <summary>
        /// Rread the price for the flowers.
        /// </summary>
        /// <param name="flowerName">The name of the flower.</param>
        /// <returns>Returns the price.</returns>
        private double ReadPrice(string flowerName)
        {
            double number = -1;
            Console.WriteLine(flowerName + ": ");
            do
            {
                var value = Console.ReadLine();
                number = GetNumber(value);

            } while (number == -1);

            return number;
        }

        /// <summary>
        /// Reads the quantity of the products sold.
        /// </summary>
        /// <param name="entityName">Name of product.</param>
        /// <returns>The number of products.</returns>
        private int ReadQuantity(string entityName)
        {
            int quantity = -1;
            double number = -1;

            Console.WriteLine("Insert quantity of " + entityName + ":");
            do
            {
                var value = Console.ReadLine();

                try
                {
                    number = GetNumber(value);
                    quantity = Convert.ToInt32(number);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception details: " + ex.Message);
                }
                finally
                {
                    if ((double)quantity != number)
                    {
                        quantity = -1;
                        Console.WriteLine("It should be an integer");
                    }
                }

            } while (quantity == -1);

            return quantity;
        }

        /// <summary>
        /// Gets the number from a string.
        /// </summary>
        /// <param name="value">The string that has been given.</param>
        /// <returns>Returns the number.</returns>
        private double GetNumber(string value)
        {
            double result = -1;
            if (value.Equals("q"))
            {
                Console.WriteLine("The application is closed. Bye!");
                Environment.Exit(0);
            }
            else
            {
                if (double.TryParse(value, System.Globalization.NumberStyles.Any, 
                    System.Globalization.CultureInfo.InvariantCulture, out result))
                {
                    if (result<0)
                    {
                        Console.WriteLine("The number must be bigger or equal with 0. Please try again!");
                    }
                }
                else
                {
                    Console.WriteLine("The inserted value is not a number. Please try again or press 'q' to exit.");
                }
            }
            return result;

        }

        /// <summary>
        /// Gets a Interval enum object from a string.
        /// </summary>
        /// <param name="valueInterval">The string that has been given.</param>
        /// <returns>Returns the Interval enum object.</returns>
        private Interval GetValidIntervalValue(string valueInterval)
        {
            Interval interval = Interval.None;
            if (valueInterval.Equals("q"))
            {
                Console.WriteLine("The application is closed. Bye!");
                Environment.Exit(0);
            }

            int intInterval;
            if (int.TryParse(valueInterval, out intInterval))
            {
                switch (intInterval)
                {
                    case (int)Interval.Day:
                        interval = Interval.Day;
                        break;
                    case (int)Interval.Week:
                        interval = Interval.Week;
                        break;
                    case (int)Interval.Month:
                        interval = Interval.Month;
                        break;
                    case (int)Interval.Year:
                        interval = Interval.Year;
                        break;
                    default:
                        Console.WriteLine("The value is incorrect. Please try again or press 'q' to exit.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The inserted value is not a number. Please try again or press 'q' to exit.");
            }

            return interval;
        }

        #endregion Private Methods
    }
}