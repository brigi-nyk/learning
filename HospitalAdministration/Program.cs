using HospitalAdministration.Data;
using HospitalAdministration.Stream;
using HospitalAdministration.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace HospitalAdministration
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bine ati venit la spitalul nostru!");
            MainView mainView = new MainView();
            mainView.GenerateMainView();
        }

    }
}
