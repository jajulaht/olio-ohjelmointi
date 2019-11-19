using System;
namespace T15_Jaakaappi
{
    public class Elintarvike
    {
        // Ominaisuudet
        public string Nimi { get; set; }
        public string ViimKayttoPaiva { get; set; }

        // Metodit
        public virtual void NaytaTiedot()
        {
            Console.WriteLine("Elintarvikkeen nimi: {0}", Nimi);
            Console.WriteLine("Viimeinen käyttöpäivä: {0}", ViimKayttoPaiva);
        }
    }
}
