using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Vehicle
{
    class Vehicle
    {
        // Julkiset ominaisuudet
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // Julkiset toiminnot eli metodit
        public void PrintData()
        {
            Console.WriteLine(ToString());
        }

        // Ylikirjoittaa Object-luokan metodin
        public override string ToString()
        {
            return Name + " " + Speed + " " + Tyres;
        }
    }
}
