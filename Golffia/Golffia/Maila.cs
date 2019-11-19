using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Maila
    {
        // Ominaisuudet
        public string Tyyppi { get; set; }
        public int Numero { get; set; }

        // Metodit
        public override string ToString()
        {
            return Tyyppi + " " + Numero;
        }
    }
}
