using System;
using System.Collections.Generic;

namespace T19_Korttipakka
{
    public class Korttipakka
    {
        // Ominaisuudet
        // Maat listassa
        List<string> Maat = new List<string> {"Hertta", "Ruutu", "Risti", "Pata" };
        // Sanakirja kortteja varten
        Dictionary<int, Kortti> Kortit = new Dictionary<int, Kortti>();

        // Luokka korteille
        public class Kortti
        {
            // Ominaisuudet
            public string Maa { get; set; }
            public int Luku { get; set; }
        }

        // Metodit
        // Pakan luomisessa käydään maat silmukassa
        // ja kutsutaan LuoMaa-metodia luomaan kyseisen maan kortit
        public void LuoPakka()
        {
            int kortinPaikka = 1; // Sanakirjan avaimet lähtevät ykkösestä
            string maa; // Apumuuttuja maille
            for (int i = 0; i < 4; i++) // Neljä maata
            {
                maa = Maat[i]; // Maataulukosta maa kerrallaan
                kortinPaikka = LuoMaa(kortinPaikka, maa);
            }

        }
        // Luo yhden maan kortit
        public int LuoMaa(int paikka, string maa)
        {
            int kortinPaikka = paikka;
            for (int j = 1; j < 14; j++) // kortit 1-13
            {
                Kortti kortti = new Kortti
                {
                    Maa = maa,
                    Luku = j
                };
                Kortit.Add(kortinPaikka, kortti);
                kortinPaikka++;
            }
            return kortinPaikka;
        }
        // Tulostaa koko pakan kortit
        public void NaytaPakka()
        {
            foreach (KeyValuePair<int, Kortti> kvp in Kortit)
            {
                Console.WriteLine(kvp.Key + " kortti on " +  kvp.Value.Maa + " " + kvp.Value.Luku);
            }
        }
    }
}
