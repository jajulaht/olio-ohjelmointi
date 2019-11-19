using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Dog : IAnimal
    {
        // Koira toteuttaa IAnimal-rajapinnan
        public string Name { get; set; }

        public string Talk()
        {
           return "Wuh wuh!";
        }

        // Voi olla muitakin ominaisuuksia ja toimintoja
    }
}
