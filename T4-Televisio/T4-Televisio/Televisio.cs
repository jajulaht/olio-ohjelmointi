using System;
namespace T4_Televisio
{
    public class Televisio
    {
        // Ominaisuudet
        public bool Virta { get; set; }
        public int Kanava { get; set; }
        public int Volume { get; set; }
        public bool Tallennus { get; set; }

        // Oletuskonstruktori
        public Televisio()
        {
        }

        // Parametrillinen konstruktori
        public Televisio(bool virta, int kanava)
        {
            Virta = virta;
            Kanava = kanava;
        }

        // Toiminnot eli metodit
        public void Info()
        {
            Console.WriteLine("Kanava: " + Kanava);
            Console.WriteLine("Volume: " + Volume);
            if (Tallennus)
            {
                Console.WriteLine("Ohjelmaa tallennetaan...");
            }
        }
        public void Guide()
        {
            Console.WriteLine("17:00   Uutiset");
            Console.WriteLine("17:30   Sää");
            Console.WriteLine("18:00   Pikkukakkonen");
            Console.WriteLine("18:30   Puoli seitsemän");
            Console.WriteLine("19:00   Ihmemies MacGyver");
            Console.WriteLine("20:00   Avara luonto");
        }

    }
}
