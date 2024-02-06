using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviVaccinationCovidCodeFirst.Modeles
{
    public class Covid19 : Immunisation
    {
        public int Covid19Id { get; set; }
        public string Variant { get; set; }

        public override string ToString()
        {
            return $"Nom du variant Covid {Variant} ";
        }
    }
}
