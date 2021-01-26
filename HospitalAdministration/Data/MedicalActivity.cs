using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public abstract class MedicalActivity
    {
        public Pacient Pacient { get; set; }
        public double Price
        {
            get
            {
                return GetPrice();
            }
        }
        public double EstimateTime { get; set; }

        public abstract double GetPrice();
        public override string ToString()
        {
            return string.Format(@"{0};{1};", Pacient.ToString(), EstimateTime);
        }
    }
}
