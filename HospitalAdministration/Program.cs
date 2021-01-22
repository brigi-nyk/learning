using System;
using System.Collections.Generic;

namespace HospitalAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Introduceti CNP");
            string cnp = Console.ReadLine();

            string yearString = cnp.Substring(1, 2);
            Console.WriteLine("Anul extras din cnp: "+ yearString);
            List<char> numbers = new List<char>() { '1', '2', '0' };

            string yearComplete = (yearString.StartsWith('0') || yearString.StartsWith('1') || yearString.StartsWith('2')) 
                ? "20" + yearString : "19" + yearString;

            Console.WriteLine("Anul complet extras din cnp: "+ yearComplete);

            string monthString = cnp.Substring(3, 2);
            string dayString = cnp.Substring(5, 2);

            DateTime birtDate = Convert.ToDateTime( dayString + "/" + monthString + "/" + yearComplete);

            Console.WriteLine("Data nasterii: "+ birtDate);
            Console.WriteLine("Data de azi: "+ DateTime.Now);

            DateTime age = DateTime.MinValue + (DateTime.Now - birtDate);

            Console.WriteLine(@"Ai {0} ani, {1} luni, {2} zile", age.Year-1, age.Month-1, age.Day-1);

        }

    }
}
