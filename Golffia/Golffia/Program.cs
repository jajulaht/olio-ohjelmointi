using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan muutama maila
            Maila rauta1 = new Maila { Tyyppi = "Rauta", Numero = 1 };
            Maila rauta2 = new Maila { Tyyppi = "Rauta", Numero = 2 };
            Maila rauta3 = new Maila { Tyyppi = "Rauta", Numero = 3 };
            Maila puu1 = new Maila { Tyyppi = "Puu", Numero = 1 };
            Maila puu2 = new Maila { Tyyppi = "Puu", Numero = 2 };
            Maila puu3 = new Maila { Tyyppi = "Puu", Numero = 3 };

            // Luodaan bägi
            Bägi bägi = new Bägi();
            bägi.LisaaMaila(rauta1);
            bägi.LisaaMaila(rauta2);
            bägi.LisaaMaila(rauta3);
            bägi.LisaaMaila(puu1);
            bägi.LisaaMaila(puu2);
            bägi.LisaaMaila(puu3);

            // Luodaan pelaaja
            Pelaaja pelaaja = new Pelaaja { Nimi = "Kirsi Kerner", Jäsennumero = 1234, Puhelin = "012-123456", Tasoitus = 3.0 };
            pelaaja.LisääBägi(bägi);

            // Tulostetaan
            Console.WriteLine(pelaaja);
            pelaaja.LyöMailalla(2);
            pelaaja.LyöMailalla(100);
        }
    }
}
