using System;
namespace T15_Jaakaappi
{
    public class Pakattu : Elintarvike
    {
        // Ominaisuudet
        public int Paino { get; set; }

        // Metodit
        public override void NaytaTiedot()
        {
            Console.WriteLine("Elintarvikkeen nimi: {0}", Nimi);
            Console.WriteLine("Viimeinen käyttöpäivä: {0}", ViimKayttoPaiva);
            Console.WriteLine("Paino: {0}", Paino);
        }
    }
}
