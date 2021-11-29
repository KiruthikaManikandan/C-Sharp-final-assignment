using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDrive
{
    public enum VaccineType
    {
        Covishield,
        Covaccine,
    }
    public class Vaccine
    {
        public string Dosage { get; set; }
        public DateTime VaccinatedDate { get; set; }
    }
}

