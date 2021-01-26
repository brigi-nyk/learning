using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalAdministration.Data
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
        }

        public  void AddDoctor(Doctor doctor)
        {

            int maxIndex = (Doctors.Count < 1) ? 0 :
                (from d in Doctors
                 select d.Id).Max();

            doctor.IncrementId(maxIndex + 1);
            
            Doctors.Add(doctor);
        }

        public void AddRangeDoctors(List<Doctor> doctors)
        {
            foreach(Doctor doc in doctors)
            {
                AddDoctor(doc);
            }
        }

        public  List<Doctor> GetDoctors()
        {
            return Doctors;
        }

        public  void EditDoctor(Doctor doctor)
        {
            foreach(Doctor doc in Doctors)
            {
                if (doc.Id == doctor.Id)
                {
                    doc.FirstName = doctor.FirstName;
                    doc.LastName = doctor.LastName;
                    doc.CNP = doctor.CNP;
                    doc.HireDate = doctor.HireDate;
                    doc.UniversityName = doctor.UniversityName;
                    doc.ResidencyYears = doctor.ResidencyYears;
                    doc.ResidencyScor = doctor.ResidencyScor;
                }
            }
        }

        public  void DeleteDoctor(Doctor doctor)
        {
            Doctors.Remove(doctor);
        }

        internal Doctor GetDoctorById(int index)
        {
            return (from d in Doctors
                   where d.Id == index
                   select d).FirstOrDefault();
        }
    }
}
