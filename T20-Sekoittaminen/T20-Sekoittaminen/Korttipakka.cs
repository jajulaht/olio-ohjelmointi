using System;
using System.Collections.Generic;

namespace T20_Sekoittaminen
{
    public class Korttipakka
    {
        // Ominaisuudet
        // Maat listassa
        List<string> Maat = new List<string> { "Hertta", "Ruutu", "Risti", "Pata" };
        // Sanakirja kortteja varten
        List<Kortti> Kortit = new List<Kortti>();

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
        public List<Kortti> LuoPakka()
        {
            string maa; // Apumuuttuja maille
            for (int i = 0; i < 4; i++) // Neljä maata
            {
                maa = Maat[i]; // Maataulukosta maa kerrallaan
                LuoMaa(maa);
            }
            return Kortit;
        }
        // Luo yhden maan kortit
        public void LuoMaa(string maa)
        {
            for (int j = 1; j < 14; j++) // kortit 1-13
            {
                Kortti kortti = new Kortti
                {
                    Maa = maa,
                    Luku = j
                };
                Kortit.Add(kortti);
            }
        }
        // Tulostaa koko pakan kortit
        public void NaytaPakka(List<Kortti> kortit)
        {
            int mones = 1;
            foreach (Kortti k in kortit)
            {
                Console.WriteLine(mones + " kortti on " + k.Maa + " " + k.Luku);
                mones++;
            }
        }
        // Sekottaa pakan kortit
        public List<Kortti> Shuffle(List<Kortti> kortit)
        {
            Random r = new Random();
            List<Kortti> sekoitetut = new List<Kortti>(); // sanakirja sekoitetuilla paikoilla
            int randomIndex = 0;
            while(kortit.Count > 0)
            {
                randomIndex = r.Next(0, kortit.Count); // valitaan satunnainen indeksi
                sekoitetut.Add(kortit[randomIndex]); // Lisätään sekoitettuun listaan
                kortit.RemoveAt(randomIndex); // Poistetaan alkuperäisestä, ettei tule duplikaatteja
            }
            return sekoitetut;
        }
    }
}
