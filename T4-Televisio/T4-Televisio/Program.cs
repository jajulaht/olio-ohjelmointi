using System;

namespace T4_Televisio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Televisio-olio
            Televisio tv1 = new Televisio();
            tv1.Virta = true;
            tv1.Kanava = 1;
            tv1.Volume = 5;
            tv1.Info();

            // Luodaan toinen Televisio-olio
            Televisio tv2 = new Televisio(true, 2);
            tv2.Volume = 6;
            tv2.Guide();
            tv2.Tallennus = true;
            tv2.Info();
            tv2.Volume--;
            tv2.Info();

            tv1.Kanava++;
            tv1.Volume--;
            tv1.Info();
        }
    }
}
