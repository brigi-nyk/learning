using HospitalAdministration.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HospitalAdministration.Stream
{
    public class DataHandling
    {
        string path;
        public DataHandling()
        {
            string workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\InputFiles\";
        }

        public void WriteDoctorsToFile(Hospital hospital)
        {
            string doctorPath = path + "doctor.csv";
            using (StreamWriter sw = File.AppendText(doctorPath))
            {
                foreach (Doctor doctor in hospital.Doctors)
                {
                    sw.WriteLine(doctor.ToString());
                }
            }
            
        }

        public void WriteMedicalActivityInFiles(Hospital hospital)
        {
            string clinicalConsultPath = path + "consult.csv",
            operationPath = path + "operatii.csv",
            recoveryPath = path +"recuperare.csv";

            List<string> clinicalConsultActivities = new List<string>();
            List<string> operationActivities = new List<string>();
            List<string> recoveryActivities = new List<string>();

            foreach (Doctor doc in hospital.Doctors)
            {
                string docId = string.Format(@"{0};", doc.Id);
                clinicalConsultActivities.AddRange(
                    (from a in doc.GetAllClinicalConsultActivities()
                     select docId + a.ToString()));
                operationActivities.AddRange(
                    (from a in doc.GetAllOperationActivities()
                     select docId + a.ToString()));
                recoveryActivities.AddRange(
                    from a in doc.GetAllRecoveryActivitis()
                    select docId + a.ToString());
            }

            using (StreamWriter sw = File.AppendText(clinicalConsultPath))
            {
                foreach (string activity in clinicalConsultActivities)
                {
                    sw.WriteLine(activity);
                }
            }

            using (StreamWriter sw = File.AppendText(operationPath))
            {
                foreach (string activity in operationActivities)
                {
                    sw.WriteLine(activity);
                }
            }

            using (StreamWriter sw = File.AppendText(recoveryPath))
            {
                foreach (string activity in recoveryActivities)
                {
                    sw.WriteLine(activity);
                }
            }
        }

        public List<Doctor> ReadDoctorsFromFile()
        {
            List<Doctor> doctors = new List<Doctor>();
            string fileName = "doctor.csv";
            string doctorPath = path + fileName;

            if (File.Exists(doctorPath))
            {
                using (StreamReader sr = File.OpenText(doctorPath))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Doctor newDoctor;
                        string[] fields = s.Split(';');
                        if (fields[7] == (1.25).ToString())
                        {
                            newDoctor = new Orthopedist();
                        }
                        else if (fields[7] == (1.5).ToString())
                        {
                            newDoctor = new InternalMedicine();
                        }
                        else if (fields[7] == (1.75).ToString())
                        {
                            newDoctor = new Cardiologist();
                        }
                        else
                        {
                            continue;
                        }
                        newDoctor.FirstName = fields[0];
                        newDoctor.LastName = fields[1];
                        newDoctor.CNP = fields[2];
                        if (DateTime.TryParse(fields[3], out DateTime date))
                        {
                            newDoctor.HireDate = date;
                        }
                        else
                        {
                            continue;
                        }
                        newDoctor.UniversityName = fields[4];
                        if (int.TryParse(fields[5], out int years))
                        {
                            newDoctor.ResidencyYears = years;
                        }
                        else
                        {
                            continue;
                        }
                        if (int.TryParse(fields[6], out int score))
                        {
                            newDoctor.ResidencyScor = score;
                        }
                        else
                        {
                            continue;
                        }
                        doctors.Add(newDoctor);
                    }
                }
            }
            else
            {
                Console.WriteLine("Fisierul {0} nu exista la aceasta adresa {1}", fileName, path);
            }
            return doctors;
        }

        public void ReadClinicalConsultActivities(Hospital hospital)
        {
            string fileName = "consult.csv";
            string clinicalConsultPath = path + fileName;

            if (File.Exists(clinicalConsultPath))
            {

                Pacient pacient = new Pacient();

                ClinicalConsult activity;

                using (StreamReader sr = File.OpenText(clinicalConsultPath))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] fields = s.Split(';');

                        if (int.TryParse(fields[0], out int index))
                        {
                            Doctor doctor = hospital.GetDoctorById(index);

                            if (doctor == null)
                            {
                                continue;
                            }

                            if (!DateTime.TryParse(fields[3], out DateTime date))
                            {
                                continue;
                            }
                            pacient = new Pacient(fields[1], fields[2], date,
                                (fields[4] == "1") ? true : false,
                                (fields[5] == "1") ? true : false);

                            if (!int.TryParse(fields[6], out int estimatedTime) ||
                                !int.TryParse(fields[8], out int frecvency))
                            {
                                continue;
                            }

                            activity = new ClinicalConsult();
                            activity.Pacient = pacient;
                            activity.EstimateTime = estimatedTime;
                            activity.IsRegular = (fields[7] == "1") ? true : false;
                            activity.MonthFrecvency = frecvency;
                            doctor.Activities.Add(activity);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Fisierul {0} nu exista la aceasta adresa {1}", fileName, path);
            }
        }

        public void ReadOperationsActivities(Hospital hospital)
        {
            string fileName = "operatii.csv";
            string operationPath = path + fileName;

            if (File.Exists(operationPath))
            {
                Pacient pacient = new Pacient();
                Operation activity;

                using (StreamReader sr = File.OpenText(operationPath))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] fields = s.Split(';');

                        if (int.TryParse(fields[0], out int index))
                        {
                            Doctor doctor = hospital.GetDoctorById(index);

                            if (doctor == null)
                            {
                                continue;
                            }

                            if (!DateTime.TryParse(fields[3], out DateTime date))
                            {
                                continue;
                            }
                            pacient = new Pacient(fields[1], fields[2], date,
                                (fields[4] == "1") ? true : false,
                                (fields[5] == "1") ? true : false);

                            if (!int.TryParse(fields[6], out int estimatedTime) ||
                                !int.TryParse(fields[7], out int anestesia) ||
                                !int.TryParse(fields[8], out int dosage))
                            {
                                continue;
                            }

                            activity = new Operation();
                            activity.Pacient = pacient;
                            activity.EstimateTime = estimatedTime;
                            activity.Anesthesia = (AnesthesiaType)anestesia;
                            activity.DosageAnesthesia = dosage;
                            doctor.Activities.Add(activity);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Fisierul {0} nu exista la aceasta adresa {1}", fileName, path);
            }
        }

        public void ReadRecoveryActivities(Hospital hospital)
        {
            string fileName = "recuperare.csv";
            string recoveryActivitiesPath = path + fileName;

            if (File.Exists(recoveryActivitiesPath))
            {
                Pacient pacient = new Pacient();
                Recovery activity;

                using (StreamReader sr = File.OpenText(recoveryActivitiesPath))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] fields = s.Split(';');

                        if (int.TryParse(fields[0], out int index))
                        {
                            Doctor doctor = hospital.GetDoctorById(index);

                            if (doctor == null)
                            {
                                continue;
                            }

                            if (!DateTime.TryParse(fields[3], out DateTime date))
                            {
                                continue;
                            }
                            pacient = new Pacient(fields[1], fields[2], date,
                                (fields[4] == "1") ? true : false,
                                (fields[5] == "1") ? true : false);

                            if (!int.TryParse(fields[6], out int estimatedTime) ||
                                !int.TryParse(fields[8], out int duration))
                            {
                                continue;
                            }

                            activity = new Recovery();
                            activity.Pacient = pacient;
                            activity.EstimateTime = estimatedTime;
                            activity.RecoveryDuration = duration;
                            doctor.Activities.Add(activity);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Fisierul {0} nu exista la aceasta adresa {1}", fileName, path);
            }
        }
    }
}
