using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monimuotoisuus
{
    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }
        // public new void Talk() // Ei ylikirjoita, vaan tekee uuden --> luokka piilottaa oman toteutuksen
        public override void Talk() // Ylikirjoittaa
        {
            Console.WriteLine("Kot kot kot!");
        }
    }
}
