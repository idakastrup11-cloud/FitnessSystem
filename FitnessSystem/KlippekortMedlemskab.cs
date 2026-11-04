using System;
using System.Collections.Generic;

namespace FitnessSystemTestØvelse
{
    // Klippekort Medlemskab
    public class KlippekortMedlemskab : Medlemskab
    {
        public List<DateTime> PTKlipDatoer { get; set; } = new List<DateTime>();

        public KlippekortMedlemskab(DateTime start, DateTime slut) : base(start, slut) { }

        public override double BeregnSamletPris()
        {
            int antalMåneder = BeregnAntalMåneder(StartDato, SlutDato);
            double pris = antalMåneder * BasisMånedsPris;

            foreach (var klipDato in PTKlipDatoer)
            {
                if (klipDato >= StartDato && klipDato <= SlutDato)
                {
                    pris += 300.0;
                }
                else
                {
                    pris -= 50.0;
                }
            }

            return pris;
        }
    }
}
