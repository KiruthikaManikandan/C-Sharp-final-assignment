using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDrive
{
    class VaccineProject
    {
        static VaccineProject VaccineMain = new VaccineProject();
        static List<Benificiery> Obj = new List<Benificiery>();
        Vaccine VaccineObj = new Vaccine();
        static void Main(string[] args)
        {

            var user1 = new Benificiery("Kiruthika", 21, "Salem", Gender.FEMALE,6381256002);
            var user2= new Benificiery("Manikandan", 44, "Chennai", Gender.MALE,9994159586);
            Obj.Add(user1);
            Obj.Add(user2);
            bool FirstDo = false;
            int Choice;
            string choice;
            do
            {
                Console.WriteLine("Welcome for the Vaccination Portal");
                Console.WriteLine("Enter the choice");
                Console.WriteLine(" 1.Beneficiery Registration  \n2.Vaccination \n3.Exit");
                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        VaccineMain.BenificieryRegistration();
                        break;
                    case 2:
                        VaccineMain.Vaccination();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
                Console.WriteLine("Do you want go to main menu: Yes / No?");
                choice = Console.ReadLine().ToUpper();
                FirstDo = false;
                if (choice == opt.YES.ToString())
                {
                    FirstDo = true;
                }

            } while (FirstDo == true);

        }
        public void BenificieryRegistration()
        {
            string RegName, RegCity;
            Gender RegGender;
            int RegAge, SelectGen, temp;
            long RegPhno;
            Console.WriteLine("Name: ");
            RegName = Console.ReadLine();
            Console.WriteLine("Age:");
            RegAge = int.Parse(Console.ReadLine());
            Console.WriteLine("City: ");
            RegCity = Console.ReadLine();
            Console.WriteLine("PhoneNumber: ");
            RegPhno = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender\n Male ->1\nFemale ->2\nTransgender ->3 : ");
            SelectGen = int.Parse(Console.ReadLine());
            if (SelectGen== 1)
            {
                RegGender = Gender.MALE;
                var Detail3 = new Benificiery(RegName, RegAge, RegCity, RegGender, RegPhno);

                Obj.Add(Detail3);

            }
            else if (SelectGen== 2)
            {
                RegGender = Gender.FEMALE;
                var Detail3 = new Benificiery(RegName, RegAge, RegCity, RegGender, RegPhno);

                Obj.Add(Detail3);
            }
            else if (SelectGen == 3)
            {
                RegGender = Gender.TRANSGENDER;
                var Detail3 = new Benificiery(RegName, RegAge, RegCity, RegGender, RegPhno);

                Obj.Add(Detail3);
            }

            foreach (Benificiery dt in Obj)
            {
                if (dt.Name == RegName)
                {
                    temp = dt.RegNo;
                    Console.WriteLine($"Hi {RegName}, Your Registration Number is : {temp}  ");
                }
            }
        }
        public void Vaccination()
        {
            VaccineType typ;
            int RegId, UserChoice;
            Console.WriteLine("Enter the Registration ID:");
            RegId = int.Parse(Console.ReadLine());
            foreach (Benificiery dt in Obj)
            {
                if (dt.RegNo == RegId)
                {
                    Console.WriteLine("Enter Your Choice:");
                    Console.WriteLine("1.Take Vaccination \n2.Vaccination History  \n3.Next due Date \n 4.EXit");
                    UserChoice = int.Parse(Console.ReadLine());
                    switch (UserChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter your Choice of Vaccine\n Covishield -> 1\nCovaxin ->2");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 1)
                            {
                                Console.WriteLine("First dose or Second Dose- 1 / 2?");
                                int dosel = int.Parse(Console.ReadLine());
                                if (dosel == 1)
                                {
                                    typ = VaccineType.Covishield;
                                    VaccineObj.Dosage = "Dose1";

                                    dt.VaccinationDetail(dt.RegNo, dt.Name, dt.Age, dt.City, dt.gender, dt.PhNo, typ, VaccineObj.Dosage);
                                }
                                else if (dosel == 2)
                                {
                                    typ = VaccineType.Covaccine;
                                    VaccineObj.Dosage = "Dose2";
                                    dt.VaccinationDetail(dt.RegNo, dt.Name, dt.Age, dt.City, dt.gender, dt.PhNo, typ, VaccineObj.Dosage);
                                }
                                else
                                {

                                    Console.WriteLine("Invalid Option");
                                }
                            }
                            else
                            {
                                Console.WriteLine("First dose or Second Dose:1 / 2?");
                                int dosel = int.Parse(Console.ReadLine());
                                if (dosel == 1)
                                {
                                    typ = VaccineType.Covaccine;
                                    VaccineObj.Dosage = "Dose1";

                                    dt.VaccinationDetail(dt.RegNo, dt.Name, dt.Age, dt.City, dt.gender, dt.PhNo, typ, VaccineObj.Dosage);
                                }
                                else if (dosel == 2)
                                {
                                    typ = VaccineType.Covaccine;
                                    VaccineObj.Dosage = "Dose2";
                                }
                                else
                                {
                                    Console.WriteLine("You have Entered wrong one");
                                }

                            }

                            break;
                        case 2:
                            dt.VaccinationHistory(dt.RegNo, dt.Name, dt.Age, dt.City, dt.gender, dt.PhNo);

                            break;
                        case 3:
                            dt.NextDueDate(dt.RegNo, dt.Name);

                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("You have entered wrong Choice");
                            break;

                    }


                }
            }

        }
    }


    public enum opt
    {
        YES,
        NO
    }
    public enum Gender
    {
        MALE,
        FEMALE,
        TRANSGENDER
    }
}
