namespace BierWinkel
{
    public class Bier : Drank
    {
        public Bier(string naam, double prijsPerStuk, Bierspecificatie bierspecificatie, Setgrootte minimumHoeveelheid) :base(naam,prijsPerStuk,minimumHoeveelheid)
        {            
            Bierspecificatie=bierspecificatie;
        }
        public Bierspecificatie Bierspecificatie { get; private set; }
        public override string ToString()
        {
            return $"{Naam},{PrijsPerStuk},{Bierspecificatie},{MinimumHoeveelheid}";
        }
    }
}