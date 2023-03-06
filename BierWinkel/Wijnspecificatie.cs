using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Wijnspecificatie : Drankspecificatie
    {
        public Wijnspecificatie(Wijnkleur? kleur, string brouwerij, Drankvolume? volume, double? alcoholPercentage, string landVanHerkomst) : base(brouwerij, volume, alcoholPercentage, landVanHerkomst)
        {
            Kleur = kleur;
        }
        public Wijnkleur? Kleur { get; private set; }

        public bool VoldoetAanSpecificatie(Wijnspecificatie spec)
        {
            bool ok = true;
            if (!base.VoldoetAanSpecificatie(spec)) ok = false;
            if (spec.GetType() != typeof(Wijnspecificatie)) return false;
            if (((Wijnspecificatie)spec).Kleur != null && ((Wijnspecificatie)spec).Kleur != this.Kleur)
                return false;
            return ok;
        }
        public override string ToString()
        {
            return $"{Kleur},{Brouwerij},{Volume},{AlcoholPercentage},{LandVanHerkomst}";
        }
    }
}
