using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Wijn : Drank
    {
        public Wijn(string naam, double prijsPerStuk, Wijnspecificatie wijnspecificatie, Setgrootte minimumHoeveelheid,Wijnspecificatie drankspecificatie) : base(naam, prijsPerStuk, minimumHoeveelheid,drankspecificatie)
        {
            //Wijnspecificatie = wijnspecificatie;
        }
        //public Wijnspecificatie Wijnspecificatie { get; private set; }
        public override string ToString()
        {
            return $"{Naam},{PrijsPerStuk},{Drankspecificatie},{MinimumHoeveelheid}";
        }
    }
}
