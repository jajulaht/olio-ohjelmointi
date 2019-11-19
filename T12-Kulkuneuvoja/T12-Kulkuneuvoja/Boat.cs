using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_Kulkuneuvoja
{
    class Boat : Vehicle
    {
        // Ominaisuudet
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        // Metodin ylikirjoitus
        public override void ShowInfo()
        {
            Console.WriteLine("Boat info");
            Console.WriteLine("Name: {0} Model: {1} Year: {2} Color: {3} BoatType: {4} SeatCount: {5}", Name, Model, Year, Color, BoatType, SeatCount);
            Console.WriteLine("");
        }
    }
}
