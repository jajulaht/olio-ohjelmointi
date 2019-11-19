using System;
using System.Collections.Generic;
namespace T14_Latka
{
    public class Pelaaja
    {
        // Ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public char Katisyys { get; set; }

        // Metodit
        public void NaytaTiedot()
        {
            Console.WriteLine("Pelaaja: {0}, {1}", Etunimi, Sukunimi);
            Console.WriteLine("Pelipaikka: {0}", Pelipaikka);
            Console.WriteLine("Kätisyys: {0}", Katisyys);
        }
    }
}
