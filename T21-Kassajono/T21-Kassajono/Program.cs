using System;
using System.Collections;
using System.Collections.Generic;

namespace T21_Kassajono
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toteuta ratkaisu, joka simuloi kaupan kassalla olevaa asiakasvirtaa. Käytä ratkaisussa jonotietorakennetta.

            // Luodaan jono-olio
            Queue<string> kassajono = new Queue<string>();
            kassajono.Enqueue("asiakas1");
            kassajono.Enqueue("asiakas2");
            Console.WriteLine("Palveltava asiakas: " + kassajono.Peek()); // asiakas1
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
            kassajono.Enqueue("asiakas3");
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
            kassajono.Dequeue();
            Console.WriteLine("Seuraava asiakas...");
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
            Console.WriteLine("Palveltava asiakas: " + kassajono.Peek()); // asiakas2
            kassajono.Dequeue();
            Console.WriteLine("Seuraava asiakas...");
            Console.WriteLine("Palveltava asiakas: " + kassajono.Peek()); // asiakas3
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
            kassajono.Enqueue("asiakas4");
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
            kassajono.Dequeue();
            Console.WriteLine("Seuraava asiakas...");
            Console.WriteLine("Palveltava asiakas: " + kassajono.Peek()); // asiakas4
            kassajono.Dequeue();
            Console.WriteLine("Kassajonossa " + kassajono.Count + " asiakasta.");
        }
    }
}
