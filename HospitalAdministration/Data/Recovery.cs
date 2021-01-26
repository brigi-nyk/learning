using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class Recovery : MedicalActivity
    {
        public int RecoveryDuration { get; set; }

        public Recovery() : base() { }

        public override double GetPrice()
        {
            double price = 0;
            double pricePerWeek = 100;

            if (RecoveryDuration<=10)
            {
                price = pricePerWeek * RecoveryDuration;
            }
            else
            {
                double numberOfDiscountWeeks = Math.Truncate((double)(RecoveryDuration - 10) / 5);

                price = pricePerWeek * (RecoveryDuration - numberOfDiscountWeeks) +
                    numberOfDiscountWeeks * (pricePerWeek - (pricePerWeek * 35 / 100));
            }

            if (Pacient.MedicalInsurance)
            {
                price -= (price * 10 / 100);
            }

            return price;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(@"{0};", RecoveryDuration);
        }
    }
}
