using System;
namespace T15_Jaakaappi
{
    public class Kiintea : Elintarvike
    {
        // Ominaisuudet
        public int Kappalemaara { get; set; }

        // Metodit
        public override void NaytaTiedot()
        {
            Console.WriteLine("Elintarvikkeen nimi: {0}", Nimi);
            Console.WriteLine("Viimeinen käyttöpäivä: {0}", ViimKayttoPaiva);
            Console.WriteLine("Kappalemäärä: {0}", Kappalemaara);
        }
    }
}
