using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalAdministration.Data
{

    public abstract class Doctor
    {

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string CNP { get; set; }
        public int Age
        {
            get
            {
                return CalculateAgeOnCNP();
            }
        }

        public DateTime HireDate { get; set; }
        public string UniversityName { get; set; }
        public int ResidencyYears { get; set; }
        public int ResidencyScor { get; set; }
        public abstract float RiscFactor { get; }
        public float Salary
        {
            get
            {
                return CalculateSalary();
            }
        }

        public List<MedicalActivity> Activities;

        private float CalculateSalary()
        {
            int workingYears = (DateTime.MinValue + (DateTime.Now - HireDate)).Year - 1;
            return 1500 * RiscFactor * workingYears;
        }

        private int CalculateAgeOnCNP()
        {

            List<char> numbers = new List<char>() { '1', '2', '0' };
            string shortBirthYear = CNP.Substring(1, 2);

            string birthYear = (shortBirthYear.StartsWith('0') || shortBirthYear.StartsWith('1') || shortBirthYear.StartsWith('2'))
                ? "20" + shortBirthYear : "19" + shortBirthYear;

            string birthMonth = CNP.Substring(3, 2);
            string birthDay = CNP.Substring(5, 2);

            DateTime birthDate = Convert.ToDateTime(birthDay + "/" + birthMonth + "/" + birthYear);
            DateTime age = DateTime.MinValue + (DateTime.Now - birthDate);

            return age.Year - 1;
        }

        private object GetWorkingHours()
        {
            var workingHours = (from a in Activities
                               select a.EstimateTime).Sum();

            return workingHours;
        }

        internal void IncrementId(int index)
        {
            Id = index;
        }

        public List<MedicalActivity> GetAllClinicalConsultActivities()
        {
            List<MedicalActivity> clinicalConsult = 
                (from a in Activities
                where a is ClinicalConsult
                select a).ToList();

            return clinicalConsult;
        }

        public List<MedicalActivity> GetAllOperationActivities()
        {
            List<MedicalActivity> operation =
                (from a in Activities
                 where a is Operation
                 select a).ToList();

            return operation;
        }

        public List<MedicalActivity> GetAllRecoveryActivitis()
        {
            List<MedicalActivity> recovery =
                (from a in Activities
                 where a is Recovery
                 select a).ToList();

            return recovery;
        }

        public override string ToString()
        {
            return string.Format(@"{0};{1};{2};{3};{4};{5};{6};{7};", FirstName, LastName, CNP, HireDate, UniversityName, ResidencyYears, ResidencyScor, RiscFactor);
        }

        public string ToShortString()
        {
            return string.Format(@"{0} - {1} {2} - Disponibil peste {3} ore", Id, FirstName, LastName, GetWorkingHours());
        }

        public string ToLongString()
        {
            return string.Format(@"{0} - {1} {2} CNP - {3}; Data angajarii: {4}; Universitate: {5}; Rezidentiat ani: {6}, scor: {7}", Id, FirstName, LastName, CNP, HireDate, UniversityName, ResidencyYears, ResidencyScor);
        }
    }
}
