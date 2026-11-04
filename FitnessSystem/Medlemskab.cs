using System;

namespace FitnessSystemTestØvelse
{
    // Den abstrakte grundklasse
    public abstract class Medlemskab
    {
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public double BasisMånedsPris { get; protected set; } = 200.0;

        public Medlemskab(DateTime startDato, DateTime slutDato)
        {
            if (startDato > slutDato)
            {
                throw new ArgumentException("Startdato kan ikke være efter slutdato.");
            }
            StartDato = startDato;
            SlutDato = slutDato;
        }

        // Hjælpemetode til at beregne antal påbegyndte måneder i perioden
        protected int BeregnAntalMåneder(DateTime start, DateTime slut)
        {
            int måneder = ((slut.Year - start.Year) * 12) + slut.Month - start.Month;

            if (slut.Day >= start.Day)
            {
                måneder++;
            }

            return måneder <= 0 ? 1 : måneder;
        }

        public abstract double BeregnSamletPris();
    }
}
