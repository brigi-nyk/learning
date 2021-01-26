using HospitalAdministration.Data;
using HospitalAdministration.Stream;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HospitalAdministration.View
{
    public class MainView
    {
        public Hospital hospital;
        public DataHandling data;
        public MainView()
        {
            hospital = new Hospital();
            data = new DataHandling();
        }

        public void GenerateMainView()
        {
            string userAnswer;
            if (hospital.Doctors == null || hospital.Doctors.Count <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Spitalul nu functioneaza. Nu sunt suficienti medici disponibili. ");
                Console.WriteLine("Apasati tasta 1 - Pentru adaugarea unui medic.");
                Console.WriteLine("Apasati tasta 2 - Pentru adaugarea medicilor din fisier.");
                userAnswer = Console.ReadLine();
                if (userAnswer.Equals("1"))
                {
                    AddNewDoctorView();
                    GenerateMainView();
                }
                else if (userAnswer.Equals("2")) {
                    Console.WriteLine();

                    string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\InputFiles\";
                    Console.WriteLine("Fisierele trebuie sa fie in folderul: {0}", path);
                    Console.WriteLine("Numele fisierelor: 'doctor.csv', 'consult.csv', 'operatii.csv' si 'recuperare.csv");

                    hospital.AddRangeDoctors(data.ReadDoctorsFromFile());
                    data.ReadClinicalConsultActivities(hospital);
                    data.ReadOperationsActivities(hospital);
                    data.ReadRecoveryActivities(hospital);
                    GenerateMainView();
                }
                else
                {
                    Console.WriteLine();

                    Console.WriteLine("Ne pare rau. Va rugam sa reveniti cu alta ocazie.");
                    Environment.Exit(0);
                }
            }
            else
            {
                do
                {
                    GetMainMenu();
                } while (true);

            }
            
        }

        private void GetMainMenu()
        {
            string userAnswer;
            Console.WriteLine();

            Console.WriteLine("Va rugam alegeti operatia pe care doriti sa o efectuati din meniul de mai jos sciind cifra aferenta:");
            Console.WriteLine("Apasati tasta 1. Programare pacient.");
            Console.WriteLine("Apasati tasta 2. Adaugare medic.");
            Console.WriteLine("Apasati tasta 3. Lista medici.");
            Console.WriteLine("Apasati tasta 4. Rapoarte.");
            Console.WriteLine("Apasati tasta 0. Pentru iesire");

        Begin:
            userAnswer = Console.ReadLine();
            switch (userAnswer)
            {
                case "0":
                    Console.WriteLine();
                    Console.WriteLine("Va multumim ca ati ales serviciile noastre!");
                    data.WriteDoctorsToFile(hospital);
                    data.WriteMedicalActivityInFiles(hospital);
                    Environment.Exit(0);
                    break;
                case "1":
                    CreatePacientAppointmentView();
                    break;
                case "2":
                    AddNewDoctorView();
                    break;
                case "3":
                    ShowDoctorsView();
                    break;
                case "4":
                    ShowReportsView();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Nu ati introdus un numar din meniu! Incercati din nou!");
                    goto Begin;
            }

        }

        private void CreatePacientAppointmentView()
        {
            bool valid;
            Pacient pacient = new Pacient();
            List<Doctor> doctors = new List<Doctor>();

            //Enter firstName:
            string firstName;
            do
            {
                valid = true;
                Console.Write("Nume: ");
                firstName = Console.ReadLine();
                if (firstName.Length <= 0)
                {
                    valid = false;
                }
            } while (!valid);
            pacient.FirstName = firstName;

            //Enter lastName
            string lastName;
            do
            {
                valid = true;
                Console.Write("Prenume: ");
                lastName = Console.ReadLine();
                if (lastName.Length <= 0)
                {
                    valid = false;
                }
            } while (!valid);
            pacient.LastName = lastName;

            //Enter birtDate
            Console.WriteLine();
            Console.WriteLine("Data Nasterii: ");
            pacient.BirthDate = GetValidDateTime();

            //Chronic disesses
            Console.WriteLine();
            Console.WriteLine("Apasati 1 - Daca suferiti de boli cronice.");
            Console.WriteLine("Apasati 2 - Daca NU suferiti de boli cronice.");
            Console.WriteLine("Apasati 0 - Pentru a va intoarce la meniul principal.");

        Begin:
            switch (Console.ReadLine())
            {
                case "1":
                    pacient.ChronicDiseases = true;
                    break;
                case "2":
                    pacient.ChronicDiseases = false;
                    break;
                case "0":
                    GetMainMenu();
                    return;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ati introdus o valoare incorecta. Alegeti o valoare din lista!");
                    goto Begin;
            }

            //Speciality
            Console.WriteLine(); 
            Console.WriteLine("Alegeti specialitate din lista de mai jos:");
            Console.WriteLine("Apasati 1 - Ortopedie");
            Console.WriteLine("Apasati 2 - Medicina interna");
            Console.WriteLine("Apasati 3 - Cardiologie");
            Console.WriteLine("Apasati 0 - Pentru a va intoarce la meniul principal.");

            do
            {
                valid = true;
                switch (Console.ReadLine())
                {
                    case "1":
                        doctors = (from d in hospital.Doctors
                                   where d is Orthopedist
                                   select d).ToList();
                        break;
                    case "2":
                        doctors = (from d in hospital.Doctors
                                   where d is InternalMedicine
                                   select d).ToList();
                        break;
                    case "3":
                        doctors = (from d in hospital.Doctors
                                   where d is Cardiologist
                                   select d).ToList();
                        break;
                    case "0":
                        GetMainMenu();
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Ati introdus o valoare incorecta. Alegeti o valoare din lista!");
                        valid = false;
                        break;
                }
            } while (!valid);

            //show all doctors available
            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine(doctor.ShortToString());
            }
            Doctor curentDoc = GetSelectedDoctor();

            //Enter medical activitie:
            Console.WriteLine(); 
            Console.WriteLine("Alegeti una din activitatile medicale de mai jos:");
            Console.WriteLine("Apasati 1 - Consultatie");
            Console.WriteLine("Apasati 2 - Operatie");
            Console.WriteLine("Apasati 3 - Recuperare");
            Console.WriteLine("Apasati 0 - Pentru a va intoarce la meniul principal.");

            MedicalActivity activity = GetMedicalActivity();
            activity.Pacient = pacient;

            Console.WriteLine();
            Console.WriteLine("Introduceti timpul estimat pentru activitatea medicala:");
            do
            {
                if (Double.TryParse(Console.ReadLine(), out double estimatedTime))
                {
                    valid = true;
                    activity.EstimateTime = estimatedTime;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Nu ati introdus un numar! Incercati din nou!");
                }
            } while (!valid);


            curentDoc.Activities.Add(activity);
        }

        private void AddNewDoctorView()
        {

            Doctor doctor;
            Console.WriteLine();
            Console.WriteLine("Adaugare medic:");

            //Enter speciality
            Console.WriteLine();
            Console.WriteLine("Alegeti una din specialitatile de mai jos scriind numarul corespunzator:");
            Console.WriteLine("1. Ortopedie.");
            Console.WriteLine("2. Medicina Interna.");
            Console.WriteLine("3. Cardiologie.");

        Begin:
            switch (Console.ReadLine())
            {
                case "1":
                    doctor = new Orthopedist();
                    break;
                case "2":
                    doctor = new InternalMedicine();
                    break;
                case "3":
                    doctor = new Cardiologist();
                    break;
                default:
                    Console.WriteLine("Alegeti una din specializarile mentionate mai sus sciind numarul corespunzator!");
                    goto Begin;
            }

            AddDoctorView(doctor);
            hospital.AddDoctor(doctor);
        }

        private void ShowDoctorsView()
        {
            Console.WriteLine();
            Console.WriteLine("Va rugam alegeti operatia pe care doriti sa o efectuati din meniul de mai jos sciind cifra aferenta:");
            Console.WriteLine("Apasati tasta 1. Afisare medici.");
            Console.WriteLine("Apasati tasta 2. Adaugare medic.");
            Console.WriteLine("Apasati tasta 3. Editare medic.");
            Console.WriteLine("Apasati tasta 4. Stergere medic.");
            Console.WriteLine("Apasati tasta 5. Calcul salarial.");
            Console.WriteLine("Apasati tasta 0. Meniul principal.");

            bool valid;
            do
            {
                valid = true;
                switch(Console.ReadLine())
                {
                    case "1":
                        GetDocorsListView();
                        break;
                    case "2":
                        AddNewDoctorView();
                        break;
                    case "3":
                        EditDoctorView();
                        break;
                    case "4":
                        DeleteDoctorView();
                        break;
                    case "5":
                        CalculateSalaryView();
                        break;
                    case "0":
                        GetMainMenu();
                        return;
                    default:
                        Console.WriteLine("Nu ati introdus un numar din meniu! Incercati din nou!");
                        break;
                }
            } while (!valid);
        }

        private void ShowReportsView()
        {
            Console.WriteLine("Urmeaza a fi implementat!");
            GetMainMenu();
        }

        #region Doctors Views

        private void AddDoctorView(Doctor doctor)
        {
            bool valid;

            //Enter firstName:
            string firstName;
            do
            {
                valid = true;
                Console.Write("Nume: ");
                firstName = Console.ReadLine();
                if (firstName.Length <= 0 || firstName.Length > 30)
                {
                    valid = false;
                }
            } while (!valid);

            //Enter lastName
            string lastName;
            do
            {
                valid = true;
                Console.Write("Prenume: ");
                lastName = Console.ReadLine();
                if (lastName.Length <= 0 || lastName.Length > 30)
                {
                    valid = false;
                }
            } while (!valid);

            

            doctor.FirstName = firstName;
            doctor.LastName = lastName;

            //Enter CNP
            bool validAge;
            do
            {
                validAge = true;
                Console.Write("CNP: ");
                doctor.CNP = Console.ReadLine();
                if (doctor.CNP.Length < 13)
                {
                    validAge = false;
                    Console.WriteLine("Prea scurt. CNP-ul trebuie sa aibe 13 cifre.");
                }
                else
                {
                    if (!Int64.TryParse(doctor.CNP, out long result))
                    {
                        validAge = false;
                        Console.WriteLine("Nu sunt numai cifre! CNP-ul trebuie sa aibe 13 CIFRE.");
                    }
                    else
                    {
                        if (doctor.Age < 28)
                        {
                            Console.WriteLine("Medicul trebuie sa aibe cel putin 28 de ani!");
                            validAge = false;
                        }
                    }
                }

            } while (!validAge);

            //Enter hireDate
            Console.WriteLine();
            Console.WriteLine("Data Angajarii: ");
            doctor.HireDate = GetValidDateTime();

            //Enter University
            Console.WriteLine();
            Console.WriteLine("Universitatea absolvita: ");
            doctor.UniversityName = Console.ReadLine();

            //Enter residential years
            Console.WriteLine();
            Console.WriteLine("Ani de rezidentiat:");
            doctor.ResidencyYears = GetValidValue();

            //Enter residential score
            Console.WriteLine();
            Console.WriteLine("Punctaj obtinut la rezidentiat:");
            do
            {
                int score = GetValidValue();

                if (score >= 75)
                {
                    valid = true;
                    doctor.ResidencyScor = score;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Prea putine puncte obtinute.Minimul trebuie sa fie 75.");
                }
            } while (!valid);

        }

        private void GetDocorsListView()
        {
            Console.WriteLine();
            Console.WriteLine("Ortopedie:");
            var ortopedistDocs = (from d in hospital.Doctors
                       where d is Orthopedist
                       select d).ToList();

            foreach (Doctor doctor in ortopedistDocs)
            {
                Console.WriteLine(doctor.LongToString());
            }

            Console.WriteLine();
            Console.WriteLine("Medicina Interna:");
            var internalDocs = (from d in hospital.Doctors
                                  where d is InternalMedicine
                                  select d).ToList();

            foreach (Doctor doctor in internalDocs)
            {
                Console.WriteLine(doctor.LongToString());
            }

            Console.WriteLine();
            Console.WriteLine("Cardiologie:");
            var cardiologistDocs = (from d in hospital.Doctors
                                    where d is Cardiologist
                                    select d).ToList();

            foreach (Doctor doctor in cardiologistDocs)
            {
                Console.WriteLine(doctor.LongToString());
            }

            ShowDoctorsView();
        }

        private void EditDoctorView()
        {
            Console.WriteLine();
            Console.WriteLine("Editare medic: ");
            Doctor doctor = GetSelectedDoctor();
            AddDoctorView(doctor);

            Console.WriteLine();
            Console.WriteLine("Noile date ale doctorului:");
            Console.WriteLine(doctor.LongToString());
        }

        private void DeleteDoctorView()
        {
            Console.WriteLine();
            Console.WriteLine("Stergere medic: ");

            hospital.DeleteDoctor(GetSelectedDoctor());

            Console.WriteLine();
            Console.WriteLine("Noua lista a medicilor:");
            GetDocorsListView();
        }

        private void CalculateSalaryView()
        {
            Doctor doctor = GetSelectedDoctor();
            Console.WriteLine();
            Console.WriteLine("Doctorul {0} {1} are salariul: {2}", 
                doctor.FirstName, doctor.LastName, doctor.Salary);
        }

        private Doctor GetSelectedDoctor()
        {
            Console.WriteLine();
            Console.WriteLine("Alegeti un medic din lista de mai sus, introducand numarul din dreptul lui:");
            Console.WriteLine("Apasati 0 - Pentru a va intoarce la meniul principal.");

            Doctor curentDoc;
            do
            {
                int doctorId = GetValidValue();
                if (doctorId == 0)
                {
                    GetMainMenu();
                    return null;
                }
                else
                {
                    curentDoc = (from d in hospital.Doctors
                                 where d.Id == doctorId
                                 select d).FirstOrDefault();
                    if (curentDoc == null)
                    {
                        Console.WriteLine("Numar incorect! Incercati din nou:");
                    }
                }

            } while (curentDoc == null);
            return curentDoc;
        }

        #endregion Doctor Views


        #region Helper Methods

        private int GetValidValue()
        {
            int result;
            bool valid;
            do
            {
                //valid = true;
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Nu ati introdus un numar! Incercati din nou!");
                }
            } while (!valid);

            return result;
        }

        private DateTime GetValidDateTime()
        {
            bool validDate;
            int year, month, day;
            Console.WriteLine("Introduceti anul:");
            do
            {
                validDate = true;
                year = GetValidValue();
                if (year > DateTime.Now.Year)
                {
                    Console.WriteLine("Anul nu poate fi din viitor!");
                    validDate = false;
                }
            } while (!validDate);

            Console.WriteLine("Introduceti luna:");
            do
            {
                validDate = true;
                month = GetValidValue();
                if (year == DateTime.Now.Year && month > DateTime.Now.Month)
                {
                    Console.WriteLine("Luna nu poate fi din viitor!");
                    validDate = false;
                }
            } while (!validDate);

            Console.WriteLine("Introduceti ziua:");
            do
            {
                validDate = true;
                day = GetValidValue();
                if (year == DateTime.Now.Year && month == DateTime.Now.Month &&
                    day > DateTime.Now.Day)
                {
                    Console.WriteLine("Ziua nu poate fi din viitor!");
                    validDate = false;
                }
            } while (!validDate);

            return new DateTime(year, month, day);
        }

        private MedicalActivity GetMedicalActivity()
        {
            MedicalActivity medicalActivity = null;
            bool valid;
            do
            {
                valid = true;
                switch (Console.ReadLine())
                {
                    case "1":
                        medicalActivity = new ClinicalConsult();
                        Console.WriteLine();
                        Console.WriteLine("Apasati 1 - Pentru consultatie care se desfaroara regulat.");
                        Console.WriteLine("Apasati 2 - Consultatie simpla.");
                        Console.WriteLine("Apasati 0 - Reveniti la meniul anterior.");
                        bool validActivity;
                        do
                        {
                            validActivity = true;
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    ((ClinicalConsult)medicalActivity).IsRegular = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Inroduceti frecventa consultatiilor (exprimata in luni):");
                                    ((ClinicalConsult)medicalActivity).MonthFrecvency = GetValidValue();
                                    break;
                                case "2":
                                    ((ClinicalConsult)medicalActivity).IsRegular = false;
                                    break;
                                case "0":
                                    Console.WriteLine("Alegeti una din activitatile medicale de mai sus:");
                                    GetMedicalActivity();
                                    break;
                                default:
                                    Console.WriteLine("Ati introdus o valoare incorecta. Alegeti o valoare din lista!");
                                    validActivity = false;
                                    break;
                            }
                        } while (!validActivity);

                        break;
                    case "2":
                        medicalActivity = new Operation();
                        Console.WriteLine();
                        Console.WriteLine("Apasati 1 - Pentru anestezie locala.");
                        Console.WriteLine("Apasati 2 - Pentru anestezie generala.");
                        Console.WriteLine("Apasati 0 - Reveniti la meniul anterior.");

                        do
                        {
                            validActivity = true;
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    ((Operation)medicalActivity).Anesthesia = AnesthesiaType.Local;
                                    Console.WriteLine("Introduceti dozajul (in ml):");
                                    ((Operation)medicalActivity).DosageAnesthesia = GetValidValue();
                                    break;
                                case "2":
                                    ((Operation)medicalActivity).Anesthesia = AnesthesiaType.General;
                                    Console.WriteLine("Introduceti dozajul (in ml):");
                                    ((Operation)medicalActivity).DosageAnesthesia = GetValidValue();
                                    break;
                                case "0":
                                    Console.WriteLine("Alegeti una din activitatile medicale de mai sus:");
                                    GetMedicalActivity();
                                    break;
                                default:
                                    Console.WriteLine("Ati introdus o valoare incorecta. Alegeti o valoare din lista!");
                                    validActivity = false;
                                    break;
                            }
                        } while (!validActivity);

                        break;
                    case "3":
                        medicalActivity = new Recovery();
                        Console.WriteLine();
                        Console.WriteLine("Introduceti durata recuperarii medicale (in saptamani):");
                        Console.WriteLine("Apasati 0 - Reveniti la meniul anterior.");

                        int recoveryInput = GetValidValue();
                        if (recoveryInput == 0)
                        {
                            GetMedicalActivity();
                        }
                        else
                        {
                            ((Recovery)medicalActivity).RecoveryDuration = recoveryInput;
                        }

                        break;
                    case "0":
                        GetMainMenu();
                        break;
                    default:
                        Console.WriteLine("Ati introdus o valoare incorecta. Alegeti o valoare din lista!");
                        valid = false;
                        break;
                }
            } while (!valid);

            return medicalActivity;
        }

        #endregion Helper Methods
    }
}
