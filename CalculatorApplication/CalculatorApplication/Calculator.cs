using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    // Tarviiko luokan olla julkinen, jolla testataan?
    public class Calculator : ICalculator
    {

        // Ominaisuudet
        // Konstruktorit
        // Metodeita

        // Rajapinnan metodien toteutus
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // Rajapinnan metodien toteutus
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
