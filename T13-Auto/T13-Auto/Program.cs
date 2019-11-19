using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Perinteinen tyyli käyttää oletuskonstruktoria
            Auto auto = new Auto();
            auto.Merkki = "Audi";
            auto.Malli = "A6";
            */

            // Sama kuin edellä, C#:lle ominaista
            // Luo uusi olio oletuskonstruktorilla ja laita samalla ominaisuudet aksessoreiden avulla
            Auto auto = new Auto
            {
                Merkki = "Audi",
                Malli = "A6"
            };

            // Autoon hiemaan renkaita, AUTO KOOSTUU RENKAISTA
            auto.LisaaRengas(new Rengas { Valmistaja = "Nokkia", Malli = "Hakkaa X", RengasKoko = "225/65R18" });
            auto.LisaaRengas(new Rengas { Valmistaja = "Nokkia", Malli = "Hakkaa X", RengasKoko = "225/65R18" });
            auto.LisaaRengas(new Rengas { Valmistaja = "Nokkia", Malli = "Hakkaa X", RengasKoko = "225/65R18" });

            // Aggrekaatio-taso --> rengas pääohjelman omaisuutta
            Rengas rengas = new Rengas
            {
                Valmistaja = "Nokkiissa",
                Malli = "Joku hieno malli",
                RengasKoko = "12121"
            };

            auto.LisaaRengas(rengas);

            // Tulostetaan auton tiedot
            auto.TulostaAutonTiedot();

            // Tuhotaan auto
            auto = null;

            // Tulotaan ja vapautetaan muistista oliot, joilla ei ole enää käyttöä
            // eli ovat esim. null-arvossa
            GC.Collect();

            // Pysäytetään
            Console.ReadLine();
        }
    }
}
