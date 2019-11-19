using System;
using System.Collections.Generic;

namespace T15_Jaakaappi
{
    public class Jaakaappi
    {
        // Ominaisuudet
        public string Nimi { get; set; }
        public List<Elintarvike> Elintarvikkeet { get; set; }

        // Metodit
        public void NaytaTiedot()
        {
            Console.WriteLine("Jääkaapin {0} sisältö:", Nimi);
            Console.WriteLine("------------------------");
            foreach (Elintarvike e in Elintarvikkeet)
            {
                e.NaytaTiedot();
            }
        }
    }
}
