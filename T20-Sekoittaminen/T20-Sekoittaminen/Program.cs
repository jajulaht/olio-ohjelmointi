using System;

namespace T20_Sekoittaminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Korttipakka kp = new Korttipakka();
            var pakka = kp.LuoPakka();
            kp.NaytaPakka(pakka);
            pakka = kp.Shuffle(pakka);
            kp.NaytaPakka(pakka);
        }
    }
}
