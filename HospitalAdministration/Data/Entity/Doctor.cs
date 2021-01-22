using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAdministration.Data.Entity
{

    public abstract class Doctor
    {

        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public long CNP { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public string UniversityName { get; set; }
        public int ResidencyYers { get; set; }
        public int ResidencyScor { get; set; }
        public abstract float RiscFactor { get; }
        public float Salary
        {
            get
            {
                return CalculateSalary();
            }
        }

        public abstract Doctor AddDoctor(Doctor doctor);
        public abstract List<Doctor> GetDoctors();
        public abstract Doctor EditDoctor(Doctor doctor);
        public abstract void DeleteDoctor(Doctor doctor);

        private float CalculateSalary()
        {
            return 1500 * RiscFactor * (DateTime.Now.Year - HireDate.Year);
        }
    }
}
