using System;
using System.Collections.Generic;

namespace GradesBookProj
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book: NameClass, IBook
    {
        public Book(string name):base(name)
        {

        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
        
    }

    
}