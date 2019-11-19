using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_Employee
{
    class Employee
    {
        // Ominaisuudet
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        // Metodit
        public virtual void NaytaTiedot()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine("Name: {0} Profession: {1} Salary: {2}", Name, Profession, Salary);
            Console.WriteLine("");
        }
    }
}
