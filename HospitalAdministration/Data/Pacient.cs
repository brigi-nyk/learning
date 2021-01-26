using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data
{
    public class Pacient
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool ChronicDiseases { get; set; }
        public bool MedicalInsurance { get; set; }
        public int Age { get; private set; }

        public Pacient() { }
        public Pacient(string firstName, string lastName, DateTime birthDate, bool? chronicDiseases, bool? medicalInsurance)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            ChronicDiseases = (chronicDiseases.HasValue && chronicDiseases.Value == true) ? true : false;
            MedicalInsurance = (medicalInsurance.HasValue && medicalInsurance.Value == true) ? true : false;

            Age = (DateTime.MinValue + (DateTime.Now - birthDate)).Year - 1;
        }

        public override string ToString()
        {
            return string.Format(@"{0};{1};{2};{3};{4}", FirstName, LastName, BirthDate,
                (ChronicDiseases) ? 1 : 0, (MedicalInsurance) ? 1 : 0);
        }
    }
}
