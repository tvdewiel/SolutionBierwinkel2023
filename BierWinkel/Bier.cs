namespace BierWinkel
{
    public class Bier : Drank
    {
        public Bier(string naam, double prijsPerStuk, Bierspecificatie bierspecificatie, Setgrootte minimumHoeveelheid,Bierspecificatie drankspecificatie) :base(naam,prijsPerStuk,minimumHoeveelheid,drankspecificatie)
        {            
            //Bierspecificatie=bierspecificatie;
        }
        //public Bierspecificatie Bierspecificatie { get; private set; }
        public override string ToString()
        {
            return $"{Naam},{PrijsPerStuk},{Drankspecificatie},{MinimumHoeveelheid}";
        }
    }
}