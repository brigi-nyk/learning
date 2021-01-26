using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class Cardiologist : Doctor
    {
        public override float RiscFactor
        {
            get
            {
                return (float)1.75;
            }
        }

        public Cardiologist() : base()
        {
            Activities = new List<MedicalActivity>();
        }

        
    }
}
