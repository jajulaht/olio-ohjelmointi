using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinoTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Pino-tietorakenne
            Stack<string> pino = new Stack<string>();

            // Lisätään 
            pino.Push("Eka");
            pino.Push("Toka");
            pino.Push("Kolmas");

            // Tulostetaan sisältö
            Console.WriteLine("Kokoelman sisältö:");
            foreach(string s in pino)
            {
                Console.WriteLine(s);
            }

            // Otetaan yksi alkio pois --> päällimmäinen
            string temp = pino.Pop();
            Console.WriteLine("Poistettu alkio:");
            Console.WriteLine(temp);

            Console.WriteLine("Kokoelman sisältö nyt:");
            foreach (string s in pino)
            {
                Console.WriteLine(s);
            }
        }
    }
}
