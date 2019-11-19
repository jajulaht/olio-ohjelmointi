using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_Employee
{
    class Boss : Employee
    {
        // Ominaisuudet
        public string Car { get; set; }
        public double Bonus { get; set; }

        // Metodit
        public override void NaytaTiedot()
        {
            Console.WriteLine("Boss:");
            Console.WriteLine("Name: {0} Profession: {1} Salary: {2} Car: {3} Bonus: {4}", Name, Profession, Salary, Car, Bonus);
            Console.WriteLine("");
        }
    }
}
