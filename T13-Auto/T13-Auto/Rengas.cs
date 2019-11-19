using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Auto
{
    class Rengas
    {
        // Ominaisuudet
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string RengasKoko { get; set; }

        public override string ToString()
        {
            return "- rengas: " + Valmistaja + " " + Malli + " " + RengasKoko;
        }

        ~Rengas()
        {
            Console.WriteLine("Rengas tuhottu!");
        }
    }
}
