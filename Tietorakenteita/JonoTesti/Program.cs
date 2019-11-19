using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonoTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jono-tietorakenne
            Queue<string> jono = new Queue<string>();

            // Lisätään porukkaa jonoon
            jono.Enqueue("Eka");
            jono.Enqueue("Toka");
            jono.Enqueue("Kolmas");

            // Tulostetaan
            Console.WriteLine("Jonon sisältö:");
            foreach(string s in jono)
            {
                Console.WriteLine(s);
            }

            // Otetaan eka pois jonosta
            string eka = jono.Dequeue();
            Console.WriteLine("Jonosta poistettu alkio oli " + eka);

            // Tulostetaan
            Console.WriteLine("Jonon sisältö nyt:");
            foreach (string s in jono)
            {
                Console.WriteLine(s);
            }
        }
    }
}
