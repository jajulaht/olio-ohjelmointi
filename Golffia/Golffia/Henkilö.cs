﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Henkilö
    {
        // Ominaisuudet
        public string Nimi { get; set; }
        public string Puhelin { get; set; }

        // Metodit
        public override string ToString()
        {
            return Nimi + " " + Puhelin;
        }
    }
}
