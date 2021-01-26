using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class ClinicalConsult : MedicalActivity
    {
        private int monthFrecvency;

        public int MonthFrecvency
        {
            get { return monthFrecvency; }
            set
            {
                if (IsRegular)
                    monthFrecvency = value;
                else
                    monthFrecvency = 0;
            }
        }

        public bool IsRegular { get; set; }

        public ClinicalConsult()
            : base() { }

        public override double GetPrice()
        {
            double price = 100;

            if (IsRegular)
            {
                price -= 5;
            }

            if (Pacient.Age >= 65)
            {
                price -= (price * 15 / 100);
            }
            if (Pacient.MedicalInsurance)
            {
                price -= (price * 7 / 100);
            }

            return price;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(@"{0};{1};",
                (IsRegular) ? 1 : 0, this.MonthFrecvency);
        }
    }
}
