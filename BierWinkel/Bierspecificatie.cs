using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Bierspecificatie : Drankspecificatie
    {
        public Bierspecificatie(Bierkleur? kleur, string brouwerij, Drankvolume? volume, double? alcoholPercentage,string landVanHerkomst) : base(brouwerij,volume,alcoholPercentage,landVanHerkomst)
        {
            Kleur = kleur;           
        }
        public Bierkleur? Kleur { get; private set; }
       
        public override bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            bool ok = true;
            if (spec.GetType() != typeof(Bierspecificatie)) return false;
            if (((Bierspecificatie)spec).Kleur != null && ((Bierspecificatie)spec).Kleur != this.Kleur) return false;
            if (!base.VoldoetAanSpecificatie(spec)) ok = false;
            return ok;
        }
        public override string ToString()
        {
            return $"{Kleur},{Brouwerij},{Volume},{AlcoholPercentage},{LandVanHerkomst}";
        }
    }
}
