using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktiivisuus
{
    class Circle : DrawingObject // Periytyminen
    {
        // perityn abstraktin metodin ylikirjoittaminen
        public override void Draw()
        {
            Console.WriteLine("Draw circle!");
        }
    }
}
