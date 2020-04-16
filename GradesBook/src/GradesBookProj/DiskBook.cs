using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GradesBookProj
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{ Name}.txt"))
            {
                writer.WriteLine(grade);
                if(GradeAdded!=null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            Statistics stat = new Statistics();

            using (var reader = File.OpenText($"{Name}.txt"))
            {
                
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    stat.Add(number);
                    line = reader.ReadLine();
                }

            }

            return stat;
        }


    }
}
