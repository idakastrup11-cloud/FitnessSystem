using System;

namespace FitnessSystemTestØvelse
{
    // Standard Medlemskab
    public class StandardMedlemskab : Medlemskab
    {
        public StandardMedlemskab(DateTime start, DateTime slut) : base(start, slut) { }

        public override double BeregnSamletPris()
        {
            int antalMåneder = BeregnAntalMåneder(StartDato, SlutDato);
            return antalMåneder * BasisMånedsPris;
        }
    }
}
