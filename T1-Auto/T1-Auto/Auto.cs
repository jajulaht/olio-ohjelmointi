using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Auto
{
    class Auto
    {
        // Ominaisuudet
        public String Merkki { get; set; }
        public String Vari { get; set; }
        public int Teho { get; set; }
        public int Nopeus { get; set; }
        public bool Karvanopat { get; set; }
        public int Ovimaara { get; set; }

        // Oletus konstruktori
        public Auto()
        {

        }
        
        // Parametrillinen konstruktori
        // PO: Auto auto = new Auto("Audi", "Musta");
        public Auto(string merkki, string vari)
        {
            // Parametrinä tuotu tieto viedään luokan ominaisuuteen
            Merkki = merkki;
            Vari = vari;
        }

        // Toiminnot eli metodit
        public void Jarruta(int maara)
        {
            Nopeus = Nopeus - maara;
        }

        public void Kiihdyta(int maara)
        {
            Nopeus = Nopeus + maara;
        }

        public void NaytaTiedot()
        {
            Console.WriteLine("Auton tiedot");
            Console.WriteLine("- merkki on " + Merkki);
            Console.WriteLine("- väri on " + Vari);
            Console.WriteLine("- teho on " + Teho);
            Console.WriteLine("- nopeus on " + Nopeus);
            if (Karvanopat)
            {
                Console.WriteLine("- karvanopat on :-) ");
            }
            else
            {
                Console.WriteLine("- karvanopat ei :-( ");
            }
            Console.WriteLine("- ovimäärä on " + Ovimaara);
        }

        public string PalautaAani()
        {
            return "HurHur";
        }

        // Destruktori eli olion tuhoaminen
        ~Auto()
        {
            Console.WriteLine("Auto tuhottu!");
        }
    }
}
