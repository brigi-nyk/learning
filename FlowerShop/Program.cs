using System;

namespace FlowerShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Flower Shop Brigi!");

            Reader reader = new Reader();

            reader.ReadAllValues();
            reader.GenerateReport();
           
        }

        
    }
}
