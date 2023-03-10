using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Drank
    {
        public Drank(string naam, double prijsPerStuk, Setgrootte minimumHoeveelheid, Drankspecificatie drankspecificatie)
        {
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("naam mag niet leeg zijn");
            Naam = naam;
            if (prijsPerStuk <= 0) throw new Exception("prijs moet groter zijn dan 0");
            PrijsPerStuk = prijsPerStuk;
            MinimumHoeveelheid = minimumHoeveelheid;
            Drankspecificatie = drankspecificatie;
        }
        public Drankspecificatie Drankspecificatie { get; private set; }
        public string Naam { get; private set; }
        public double PrijsPerStuk { get; private set; }
        public Setgrootte MinimumHoeveelheid { get; private set; }
        public override string ToString()
        {
            return $"{Naam}";
        }
    }
}
