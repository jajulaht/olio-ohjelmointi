using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Merkki = "Seat"; // Käyttää set-aksessoria
            auto.Nopeus = 300; // Käyttää set-aksessoria

            Console.WriteLine("Auton tiedot: {0} {1}", auto.Merkki, auto.Nopeus);

            Auto auto2 = new Auto("Audi", 300);
            Console.WriteLine("Auton tiedot: {0} {1}", auto2.Merkki, auto2.Nopeus);

            auto2.Kiihdyta(1000);
            Console.WriteLine("Auton tiedot: {0} {1}", auto2.Merkki, auto2.Nopeus);
        }
    }
}
