using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Drankspecificatie
    {
        public Drankspecificatie(string brouwerij, Drankvolume? volume, double? alcoholPercentage, string landVanHerkomst)
        {
            if (string.IsNullOrWhiteSpace(brouwerij)) throw new Exception("brouwerij mag niet leeg zijn");
            Brouwerij = brouwerij;
            Volume = volume;
            if (alcoholPercentage < 0) throw new Exception("percentage kan niet kleiner dan 0 zijn");
            AlcoholPercentage = alcoholPercentage;
            if (string.IsNullOrWhiteSpace(landVanHerkomst)) throw new Exception("land is leeg");
            LandVanHerkomst = landVanHerkomst;
        }
        public string Brouwerij { get; private set; }
        public Drankvolume? Volume { get; private set; }
        public double? AlcoholPercentage { get; private set; }
        public string LandVanHerkomst { get; private set; }
        public virtual bool VoldoetAanSpecificatie(Drankspecificatie spec)
        {
            bool ok = true;
            if (!string.IsNullOrWhiteSpace(spec.Brouwerij) && spec.Brouwerij != Brouwerij) ok = false;
            if (spec.Volume.HasValue && spec.Volume > 0 && spec.Volume != Volume) ok = false;
            if (spec.AlcoholPercentage.HasValue && spec.AlcoholPercentage >= 0 && spec.AlcoholPercentage != AlcoholPercentage) ok = false;
            if (!string.IsNullOrWhiteSpace(spec.LandVanHerkomst) && spec.LandVanHerkomst != LandVanHerkomst) ok = false;
            return ok;
        }
    }
}
