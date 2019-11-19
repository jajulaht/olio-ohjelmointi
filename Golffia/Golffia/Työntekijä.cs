using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Työntekijä : Henkilö
    {
        // Ominaisuudet
        public bool Kulkulupa { get; set; }

        // Metodit
        public void LeikkaaRuohoa()
        {
            Console.WriteLine("Leikkaa ruohoa!");
        }
        public override string ToString()
        {
            if (Kulkulupa) return base.ToString() + " Kulkulupa löytyy!";
            else return base.ToString() + " Ei kulkulupaa!";
            // return base.ToString();
        }
    }
}
