using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktiivisuus
{
    abstract class DrawingObject
    {
        // ominaisuus
        public string Name { get; set; }

        // oletuskonstruktori
        public DrawingObject()
        {

        }

        // parametrillinen konstruktori
        public DrawingObject(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        // abstrakti toiminto, ei aaltosulkeilla rajattua lohkoa
        // aliluokkien on pakko ylikirjoittaa tämä toiminto
        public abstract void Draw();
    }
}
