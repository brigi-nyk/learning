using System;
using System.Collections.Generic;
using System.Text;

namespace GradesBookProj
{
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}
