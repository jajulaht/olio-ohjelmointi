using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("2 + 3 = " + calc.Add(2, 3));

            Console.WriteLine("2 * 3 = " + calc.Multiply(2, 3));
        }
    }
}
