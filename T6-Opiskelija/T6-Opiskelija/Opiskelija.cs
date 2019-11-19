using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Opiskelija
{
    class Opiskelija
    {
        // Julkiset ominaisuudet
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpiskelijaNumero { get; set; }
        public string Katuosoite { get; set; }
        public string Postinumero { get; set; }
        public string Paikkakunta { get; set; }
        public string Pääaine { get; set; }
        public int Opintopisteet { get; set; }

        // Julkiset metodit
        public void NaytaTiedot()
        {
            Console.WriteLine(Etunimi);
            Console.WriteLine(Sukunimi);
            Console.WriteLine(OpiskelijaNumero);
            Console.WriteLine(Katuosoite);
            Console.WriteLine(Postinumero);
            Console.WriteLine(Paikkakunta);
            Console.WriteLine(Pääaine);
            Console.WriteLine(Opintopisteet);
        }


    }
}
