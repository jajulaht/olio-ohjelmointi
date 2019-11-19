using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_Hissi
{
    class Elevator
    {
        // min ja max
        private const int minFloor = 1;
        private const int maxFloor = 5;

        // private fields
        private int floor = 1; // Oletuksena ykköskerroksessa
        private bool isFloorValid { get; set; } = true;

        // public property, julkinen kerros-muuttuja
        public int Floor { get
            {
                return floor;
            }
            set {
                if(value < minFloor)
                {
                    isFloorValid = false;
                }
                else if (value > maxFloor)
                {
                    isFloorValid = false;
                }
                else
                {
                    isFloorValid = true;
                    floor = value; // value on sallitulla välillä
                }
                ShowFloorMessage();
            }
        }

        // private method, voi kutsua vain luokan sisällä
        private void ShowFloorMessage()
        {
            if(isFloorValid)
            {
                Console.WriteLine("Selected floor is valid. Floor is " + floor);
            }
            else
            {
                Console.WriteLine("Selected floor is not valid. Floor is " + floor);
            }
            
        }
    }
}
