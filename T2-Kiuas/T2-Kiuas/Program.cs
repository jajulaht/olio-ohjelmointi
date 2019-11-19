using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Kiuas-olio
            T2_Kiuas kiuas1 = new T2_Kiuas();
            kiuas1.VirtaPaalla = true;
            kiuas1.Lampo = 80;
            kiuas1.Kosteus = 60;

            // Luodaan toinen Kiuas-olio
            T2_Kiuas kiuas2 = new T2_Kiuas();
            kiuas2.VirtaPaalla = true;
            kiuas2.Lampo = 100;
            kiuas2.Kosteus = 40;

            // Luodaan merkkijonoja kiukaan metodilla
            string loyly1 = kiuas1.HeitaLoylya();
            string loyly2 = kiuas2.HeitaLoylya();
     
            Console.WriteLine("Kiuas 1: " + loyly1);
            Console.WriteLine("Kiuas 2: " + loyly2);
            Console.WriteLine("Kiuas 2: " + loyly2);

            Console.WriteLine("");
            Console.WriteLine("Kiuas 1: ");
            kiuas1.NaytaTiedot();
            Console.WriteLine("");
            Console.WriteLine("Kiuas 2: ");
            kiuas2.NaytaTiedot();
        }
    }
}
