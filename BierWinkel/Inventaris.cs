using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Inventaris
    {
        public Dictionary<string,Drank> Dranken=new Dictionary<string, Drank>();
        public void VoegDrankToe(string naam, double prijsPerStuk, Drankspecificatie drankspecificatie, Setgrootte minimumHoeveelheid)
        {
            Drank drank=new Drank(naam,prijsPerStuk,minimumHoeveelheid, drankspecificatie);
            if (!Dranken.ContainsKey(naam)) Dranken.Add(naam,drank);
        }
        public Drank SelecteerDrank(string naam)
        {
            if (Dranken.ContainsKey(naam)) return Dranken[naam];
            return null;
        }
        public List<Drank> ZoekDrank(Drankspecificatie drank)
        {
            List<Drank> gevondenDranken= new List<Drank>();  
            foreach(Drank b in Dranken.Values)
            {
                if (b.Drankspecificatie.VoldoetAanSpecificatie(drank)) gevondenDranken.Add(b);
            }
            return gevondenDranken;
        }
    }
}
