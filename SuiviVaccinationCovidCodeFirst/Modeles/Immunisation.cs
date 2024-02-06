using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinationCovidCodeFirst.Modeles
{
    public class Immunisation
    {
        public int ImmunisationId { get; set; } 
        public DateTime Date { get; set; }
        public string NAMPatient { get; set; } 
       
    }
}
