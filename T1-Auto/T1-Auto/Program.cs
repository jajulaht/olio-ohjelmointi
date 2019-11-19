using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Auto
{
    // Program.main(); Luokan staattinen metodi voidaan ajaa suoraan, ei luoda oliota

    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Auto-olio
            Auto auto = new Auto();
            auto.Merkki = "Seat";
            auto.Teho = 180;
            auto.Nopeus = 100;
            auto.Ovimaara = 4;
            auto.Vari = "Punainen";
            auto.Karvanopat = false;

            auto.NaytaTiedot();

            auto.Kiihdyta(30);
            auto.NaytaTiedot();

            auto.Jarruta(20);
            auto.NaytaTiedot();

            string aani = auto.PalautaAani();
            Console.WriteLine("Auton ääni on = " + aani);

            // Luodaan toinen olio Auto-luokasta
            Auto biili = new Auto("Audi", "Musta");
            biili.NaytaTiedot();
            // Loppuu
        }
    }
}
