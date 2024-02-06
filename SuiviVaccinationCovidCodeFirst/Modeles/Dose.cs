using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinationCovidCodeFirst.Modeles
{
    public class Dose : Immunisation
    {
        public int DoseId { get; set; }
        //public DateTime Date { get; set; }
        //public string NAMPatient { get; set; }
        public string Nom { get; set; }
        public Vaccin Vaccin { get; set; }
        public int NumeroDose { get; set; }

        public override string ToString()
        {
            return $"Vaccin # {DoseId} ({Vaccin?.Nom}), administré le {Date} a {NAMPatient} , vous avez deja recu {NumeroDose} Dose(s)";
        }

    }
}
