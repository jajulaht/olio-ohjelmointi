using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_Kulkuneuvoja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olioita
            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.Year = 2016;
            bike.Color = "Blue";
            bike.GearWheels = false;
            //bike.GearName = "";


            Bike bike2 = new Bike();
            bike2.Name = "Tunturi";
            bike2.Model = "StreetPower";
            bike2.Year = 2010;
            bike2.Color = "Black";
            bike.GearWheels = true;
            bike.GearName = "Shimano";

            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.Year = 1990;
            boat.Color = "White";
            boat.BoatType = "Rowboat";
            boat.SeatCount = 3;

            Boat boat2 = new Boat();
            boat2.Name = "Yamaha";
            boat2.Model = "Model 1000";
            boat2.Year = 2010;
            boat2.Color = "Yellow";
            boat2.BoatType = "Motorboat";
            boat2.SeatCount = 5;

            // Kootaan listaan
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(bike);
            vehicles.Add(bike2);
            vehicles.Add(boat);
            vehicles.Add(boat2);

            // Tulostetaan listan alkiot yksi kerrallaan
            foreach(Vehicle v in vehicles)
            {
                v.ShowInfo();
            }
        }
    }
}
