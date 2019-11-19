using System;

namespace T9_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Virta = true;
            radio.Taajuus = 3000;
            radio.Volume = 4;
            Console.WriteLine("Radion virta {0}, taajuus {1} ja äänenvoimakkuus {2} ", radio.Virta, radio.Taajuus, radio.Volume);

            radio.Taajuus = 6000;
            Console.WriteLine("Radion virta {0}, taajuus {1} ja äänenvoimakkuus {2} ", radio.Virta, radio.Taajuus, radio.Volume);

            radio.Taajuus = 1000;
            Console.WriteLine("Radion virta {0}, taajuus {1} ja äänenvoimakkuus {2} ", radio.Virta, radio.Taajuus, radio.Volume);

            radio.Volume = 10;
            Console.WriteLine("Radion virta {0}, taajuus {1} ja äänenvoimakkuus {2} ", radio.Virta, radio.Taajuus, radio.Volume);

            radio.Volume = 5;
            Console.WriteLine("Radion virta {0}, taajuus {1} ja äänenvoimakkuus {2} ", radio.Virta, radio.Taajuus, radio.Volume);
        }
    }
}
