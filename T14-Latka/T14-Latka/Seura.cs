using System;
using System.Collections.Generic;

namespace T14_Latka
{
    public class Seura
    {
        // Ominaisuudet
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        // Metodit
        public void NaytaTiedot()
        {
            Console.WriteLine("Seura: {0}", Nimi);
            Console.WriteLine("Pelaajat:");
            Console.WriteLine("----------");
            foreach (Pelaaja p in Pelaajat)
            {
                p.NaytaTiedot();
            }
            Console.WriteLine("");
        }
    }
}
