using System;

namespace GradesBookProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Brigi's Book");

            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            
            string input;
            do
            {
                Console.Write("Type a grade: ");
                input = Console.ReadLine();
                double grade ;
                if (double.TryParse(input, out grade))
                {
                    book.AddGrade(grade);
                }
                else
                {
                    if (input.Length == 1)
                    {
                        book.AddGrade(input[0]);
                    }
                    Console.WriteLine($"This {input} is not a grade!");
                }
            } while (input.ToUpper() != "Q");

            
            var result = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The average grade is {result.Average:N1}");
            Console.WriteLine($"The average letter grade is {result.Letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("The grade was added");
        }
    }
}
