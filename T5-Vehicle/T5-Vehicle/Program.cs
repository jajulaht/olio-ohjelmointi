using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Mopo";
            vehicle.Speed = 45;
            vehicle.Tyres = 2;

            vehicle.PrintData();

            vehicle.Speed--;
            vehicle.PrintData();
            vehicle.Speed--;
            vehicle.PrintData();

            vehicle.Name = "Moottoripyörä";
            vehicle.Speed = 100;
            vehicle.PrintData();
            vehicle.Speed = 150;
            vehicle.PrintData();

            vehicle.Name = "Auto";
            vehicle.Speed = 120;
            vehicle.PrintData();
            vehicle.Speed = 80;
            vehicle.PrintData();
        }
    }
}
