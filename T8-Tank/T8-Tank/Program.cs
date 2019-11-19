using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.Name = "Tankki";
            tank.Type = "Kevytvehje";
            tank.CrewCount = 5;

            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.AccerelateTo(40);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.AccerelateTo(40);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.AccerelateTo(40);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.SlowTo(20);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.SlowTo(20);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.SlowTo(20);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.SlowTo(20);
            Console.WriteLine("Tankin nopeus on: " + tank.Speed);
            tank.CrewCount = 0;
            Console.WriteLine("Tankissa miehistöä: " + tank.CrewCount);
            tank.CrewCount = 2;
            Console.WriteLine("Tankissa miehistöä: " + tank.CrewCount);
        }
    }
}
