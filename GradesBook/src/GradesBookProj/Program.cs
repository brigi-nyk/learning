using System;

namespace GradesBookProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskBook book = new DiskBook("Brigi's Book");

            book.GradeAdded += OnGradeAdded;

            EnterGrades(null);

            var result = book.GetStatistics();

            Console.WriteLine($"For the book name {book.Name}");
            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The average grade is {result.Average:N1}");
            Console.WriteLine($"The average letter grade is {result.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            string input;
            do
            {
                Console.Write("Type a grade: ");
                input = Console.ReadLine();
                double grade;
                if (double.TryParse(input, out grade))
                {
                    book.AddGrade(grade);
                }
                else
                {
                    //if (input.Length == 1)
                    //{
                    //    book.AddGrade(input[0]);
                    //}
                    Console.WriteLine($"This {input} is not a grade!");
                }
            } while (input.ToUpper() != "Q");


            
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("The grade was added");
        }
    }
}
