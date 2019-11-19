using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Cat : IAnimal
    {
        // Kissa toteuttaa IAnimal-rajapinnan
        public string Name { get; set; }

        public string Talk()
        {
            return "Miau!";
        }

        // Voi olla muitakin ominaisuuksia ja toimintoja
    }
}
