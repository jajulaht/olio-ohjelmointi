using System;
namespace T15_Jaakaappi
{
    public class Neste : Elintarvike
    {
        // Ominaisuudet
        public double Tilavuus { get; set; }

        // Metodit
        public override void NaytaTiedot()
        {
            Console.WriteLine("Elintarvikkeen nimi: {0}", Nimi);
            Console.WriteLine("Viimeinen käyttöpäivä: {0}", ViimKayttoPaiva);
            Console.WriteLine("Tilavuus: {0}", Tilavuus);
        }
    }
}
