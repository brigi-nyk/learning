using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class InternalMedicine : Doctor
    {
        public override float RiscFactor
        {
            get
            {
                return (float)1.5;
            }
        }

        public InternalMedicine():base()
        {
            Activities = new List<MedicalActivity>();
        }
    }
}
