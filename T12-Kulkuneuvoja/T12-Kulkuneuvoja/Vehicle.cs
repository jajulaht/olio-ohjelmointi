using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_Kulkuneuvoja
{
    class Vehicle
    {
        // Ominaisuudet
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Metodit
        public virtual void ShowInfo()
        {
            Console.WriteLine("Vehicle info");
            Console.WriteLine("Name: {0} Model: {1} Year: {2} Color: {3}", Name, Model, Year, Color);
            Console.WriteLine("");
        }
    }
}
