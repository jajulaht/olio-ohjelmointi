using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            bool result;
            do
            {
                // get floor
                Console.WriteLine("Elevator is now in floor: " + elevator.Floor); // get-aksessori
                // show text
                Console.WriteLine("Give a new floor number (1-5) > ");
                // read line
                string line = Console.ReadLine();
                // get typed floor, string --> int
                // "2" --> 2, "kissa" --> ?
                // result == true, if parse succesful, false if not
                result = Int32.TryParse(line, out int floor);
                if(result)
                {
                    // try to set a new floor
                    elevator.Floor = floor; // set-aksessori
                }
            }
            while (result); // ohjelma loppuu, jos ei tule oikeata arvoa
        }
    }
}
