using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Kiuas
{
    class T2_Kiuas
    {
        // Kotikoneelta muokattu versio
        // Ominaisuudet
        public bool VirtaPaalla { get; set; }
        public int Lampo { get; set; }
        public int Kosteus { get; set; }

        // Konstruktorit

        // Toiminnot eli metodit
        public string HeitaLoylya()
        {
            return "SSSSHHHHHH!!!!";
        }
        public void NaytaTiedot()
        {
            Console.WriteLine("Kiukaan tiedot");
            Console.WriteLine("Lämpötila on " + Lampo);
            Console.WriteLine("Kosteus on " + Kosteus);
        }
    }
}
