using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class Orthopedist : Doctor
    {
        public override float RiscFactor
        {
            get
            {
                return (float)1.25;
            }
        }

        public Orthopedist():base()
        {
            Activities = new List<MedicalActivity>();
        }
    }
}
