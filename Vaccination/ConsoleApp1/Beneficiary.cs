using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDrive
{

    class Benificiery
    {
        Vaccine obj = new Vaccine();

        private static int id = 1001;
        public List<Vaccine> VaccinatioDetail { get; set; }

        public int RegNo;

        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public Gender gender { get; set; }

        public long PhNo { get; set; }

        public Benificiery(string name, int age, string city, Gender a, long phno)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.PhNo = phno;
            this.gender = a;
            this.RegNo = id;
            id++;


        }
        public void VaccinationDetail(int reg, string name, int age, string city, Gender a, long phno, VaccineType b, string dose)
        {
            obj.VaccinatedDate = DateTime.Today;


            string VacDate = obj.VaccinatedDate.ToString("d");

            Console.WriteLine($"Hi! {name} you can vaccinate on{VacDate}.Thank You! the vaccine of {b}{dose} ");


        }
        public void VaccinationHistory(int reg, string name, int age, string city, Gender a, long phno)
        {
            string VacDate = obj.VaccinatedDate.ToString("d");
            Console.WriteLine($"Name: {name} \n Age:{age}\nCity={city}\nGender:{a.ToString()}\n PhoneNo:{phno}\n Date:{VacDate}");
        }
        public void NextDueDate(int reg, string name)
        {
            DateTime newDate = obj.VaccinatedDate.AddDays(30);
            string NextDate = newDate.ToString("d");
            Console.WriteLine("Your next vaccination date is:");

        }


    }
}
