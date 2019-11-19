using System;

namespace T3_Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Pesukone-olio, ohjelma default
            Pesukone pesukone1 = new Pesukone();
            pesukone1.VirtaPaalla = true;
            pesukone1.Ohjelma = pesukone1.OhjelmaVal(0);
            pesukone1.Linkous = true;
            pesukone1.LinkousRPM = 500;

            pesukone1.NaytaTiedot();
            Console.WriteLine("");

            Pesukone pesukone2 = new Pesukone(true, 2);
            pesukone2.Linkous = false;

            pesukone2.NaytaTiedot();
            Console.WriteLine("");

            Pesukone pesukone3 = new Pesukone(true, 3, true, 1500);
            pesukone3.NaytaTiedot();
            Console.WriteLine("");

            pesukone1.LinkousRPM = 1000;
            pesukone1.NaytaTiedot();
            Console.WriteLine("");

            pesukone1.Lopetus();
            pesukone2.Lopetus();
            pesukone3.Lopetus();
        }
    }
}
