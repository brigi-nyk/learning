using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public enum AnesthesiaType
    {
        Local,
        General
    }

    public class Operation : MedicalActivity
    {
        public AnesthesiaType Anesthesia { get; set; }
        public int DosageAnesthesia { get; set; }

        public Operation() : base() { }


        public override double GetPrice()
        {
            double price = 0;

            if (Anesthesia == AnesthesiaType.Local)
            {
                price = 150 * DosageAnesthesia;
            }
            else
            {
                price = 200 * DosageAnesthesia;
            }

            if (Pacient.MedicalInsurance)
            {
                price -= (price * 15 / 100);
            }

            return price;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(@"{0};{1};", (int)Anesthesia, DosageAnesthesia);
        }
    }
}
