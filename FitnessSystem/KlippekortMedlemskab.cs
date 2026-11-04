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
                // Gammel kode: fejler TC11, fordi klokkeslættet også sammenlignes.
                // if (klipDato >= StartDato && klipDato <= SlutDato)
                // {
                //     pris += 300.0;
                // }
                // else
                // {
                //     // Fejler TC10: ugyldige klip skal ignoreres.
                //     pris -= 50.0;
                // }

                if (klipDato.Date >= StartDato.Date && klipDato.Date <= SlutDato.Date)
                {
                    pris += 300.0;
                }
            }

            return pris;
        }
    }
}
