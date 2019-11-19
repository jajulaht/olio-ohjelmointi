using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    interface ICalculator
    {
        // Jos joku lupaa toteutta rajapinnan
        // on ainakin nämä metodit tehtävä
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
    }
}
