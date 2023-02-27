using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Inventaris
    {
        public Dictionary<string,Bier> Biertjes=new Dictionary<string, Bier>();
        public void VoegBierToe(string naam, double prijsPerStuk, Bierspecificatie bierspecificatie, Setgrootte minimumHoeveelheid)
        {
            Bier bier=new Bier(naam,prijsPerStuk,bierspecificatie,minimumHoeveelheid);
            if (!Biertjes.ContainsKey(naam)) Biertjes.Add(naam,bier);
        }
        public Bier SelecteerBier(string naam)
        {
            if (Biertjes.ContainsKey(naam)) return Biertjes[naam];
            return null;
        }
        public List<Bier> ZoekBier(Bierspecificatie bier)
        {
            List<Bier> gevondenBiertjes= new List<Bier>();  
            foreach(Bier b in Biertjes.Values)
            {
                if (b.Bierspecificatie.VoldoetAanSpecificatie(bier)) gevondenBiertjes.Add(b);
            }
            return gevondenBiertjes;
        }
    }
}
