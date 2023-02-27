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
       
        public bool VoldoetAanSpecificatie(Bierspecificatie spec)
        {
            bool ok = true;
            if (spec.Kleur != null && spec.Kleur != Kleur) ok=false;
            if (!string.IsNullOrWhiteSpace(spec.Brouwerij) && spec.Brouwerij != Brouwerij) ok = false;
            if (spec.Volume.HasValue && spec.Volume > 0 && spec.Volume != Volume) ok = false;
            if (spec.AlcoholPercentage.HasValue && spec.AlcoholPercentage >= 0 && spec.AlcoholPercentage != AlcoholPercentage) ok = false;
            if (!string.IsNullOrWhiteSpace(spec.LandVanHerkomst) && spec.LandVanHerkomst != LandVanHerkomst) ok = false;
            return ok;
        }
        public override string ToString()
        {
            return $"{Kleur},{Brouwerij},{Volume},{AlcoholPercentage},{LandVanHerkomst}";
        }
    }
}
