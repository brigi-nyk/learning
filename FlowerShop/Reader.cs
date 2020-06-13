using System;

namespace FlowerShop
{
    internal class Reader
    {

        #region Properties

        public int NoBigBouquets { get; set; }
        public int NoMediumBouquets { get; set; }
        public int NoSmallBouquets { get; set; }
        public int NoRoses { get; set; }
        public int NoGladiolis { get; set; }
        public int NoOrchids { get; set; }

        public Interval FirstInterval { get; set; }
        public Interval RequestedInterval { get; set; }

        #endregion Properties

        public Reader()
        {
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
        internal void ReadAllValues()
        {
            Console.WriteLine("Please insert a number that corresponds to an interval and press Enter: ");

            var values = Enum.GetValues(typeof(Interval));
            foreach (var value in values)
            {
                Console.WriteLine(((int)value).ToString() + ": " + value);
            }

            
            do
            {
                FirstInterval = GetValidIntervalValue(Console.ReadLine());
            } while (FirstInterval == Interval.None);

            NoBigBouquets = ReadQuantity("big bouquets", FirstInterval);
            NoMediumBouquets = ReadQuantity("medium bouquets", FirstInterval);
            NoSmallBouquets = ReadQuantity("small bouquets", FirstInterval);
            NoRoses = ReadQuantity("roses", FirstInterval);
            NoGladiolis = ReadQuantity("gladiolis", FirstInterval);
            NoOrchids = ReadQuantity("orchids", FirstInterval);

            Console.WriteLine("Please insert a number that corresponds to an interval in order to create a report");
            do
            {
                RequestedInterval = GetValidIntervalValue(Console.ReadLine());

                if (RequestedInterval <= FirstInterval)
                {
                    Console.WriteLine("The interval for the report must be bigger. Please try again!");
                }
            } while (RequestedInterval <= FirstInterval);
        }

        /// <summary>
        /// Generates the report.
        /// </summary>
        internal void GenerateReport()
        {
            Report report = new Report(FirstInterval, NoBigBouquets, NoMediumBouquets,
                NoSmallBouquets, NoRoses, NoGladiolis, NoOrchids);
            report.CreateReport(RequestedInterval);
        }

        #region Private Methods

        /// <summary>
        /// Reads the quantity of the products sold in the specified interval time.
        /// </summary>
        /// <param name="entityName">Name of product.</param>
        /// <param name="interval">The interval in wicth the product was sold.</param>
        /// <returns>The number of products.</returns>
        private int ReadQuantity(string entityName, Interval interval)
        {
            int number = -1;
            
            Console.WriteLine("Insert how many " + entityName + " where sold in one " + interval + ":");
            do
            {
                var value = Console.ReadLine();
                number = GetNumber(value);
                
            } while (number == -1);

            return number;
        }

        /// <summary>
        /// Gets the number from a string.
        /// </summary>
        /// <param name="value">The string that has been given.</param>
        /// <returns>Returns the number.</returns>
        private int GetNumber(string value)
        {
            int result = -1;
            if (value.Equals("q"))
            {
                Console.WriteLine("The application is closed. Bye!");
                Environment.Exit(0);
            }
            else
            {
                if (int.TryParse(value, out result))
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