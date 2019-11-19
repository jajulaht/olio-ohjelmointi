using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_Kulkuneuvoja
{
    class Bike : Vehicle
    {
        // Ominaisuudet
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        // Metodin ylikirjoitus
        public override void ShowInfo()
        {
            Console.WriteLine("Bike info");
            Console.WriteLine("Name: {0} Model: {1} Year: {2} Color: {3} GearWheels: {4} GearName: {5}", Name, Model, Year, Color, GearWheels, GearName);
            Console.WriteLine("");
        }
    }
}
