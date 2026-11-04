using System;

namespace FitnessSystemTestØvelse
{
    // Bindingsmedlemskab
    public class BindingsMedlemskab : Medlemskab
    {
        public int BindingsMåneder { get; set; }

        public BindingsMedlemskab(DateTime start, DateTime slut, int bindingsMåneder) : base(start, slut)
        {
            BindingsMåneder = bindingsMåneder;
            BasisMånedsPris = 150.0;
        }

        public override double BeregnSamletPris()
        {
            int aktueltAntalMåneder = BeregnAntalMåneder(StartDato, SlutDato);
            double pris = aktueltAntalMåneder * BasisMånedsPris;

            if (aktueltAntalMåneder <= BindingsMåneder)
            {
                pris += 500.0;
            }

            return pris;
        }
    }
}
