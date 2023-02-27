using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Wijn : Drank
    {
        public Wijn(string naam, double prijsPerStuk, Wijnspecificatie wijnspecificatie, Setgrootte minimumHoeveelheid) : base(naam, prijsPerStuk, minimumHoeveelheid)
        {
            Wijnspecificatie = wijnspecificatie;
        }
        public Wijnspecificatie Wijnspecificatie { get; private set; }
        public override string ToString()
        {
            return $"{Naam},{PrijsPerStuk},{Wijnspecificatie},{MinimumHoeveelheid}";
        }
    }
}
