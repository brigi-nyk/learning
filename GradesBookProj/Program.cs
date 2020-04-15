using System;

namespace GradesBookProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Brigi's Book");
            book.AddGrade(45.12);
            book.AddGrade(75.23);
            book.AddGrade(12.8);
            book.AddGrade(89.56);
            book.AddGrade(98);
            book.AddGrade(26.84);
            book.ShowStatistics();

        }
    }
}
