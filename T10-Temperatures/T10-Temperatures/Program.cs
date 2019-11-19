using System;

namespace T10_Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testataan lämpötilalaskuria
            double fAste1 = 50.5;
            double cAste1 = T10_Temperatures.Temperature.toCelcius(fAste1);
            Console.WriteLine("Fahrenheit-asteet {0} ovat celsius-asteina {1}.", fAste1, cAste1);

            double fAste2 = 80;
            double cAste2 = T10_Temperatures.Temperature.toCelcius(fAste2);
            Console.WriteLine("Fahrenheit-asteet {0} ovat celsius-asteina {1}.", fAste2, cAste2);

            double cAste3 = 25.5;
            double fAste3 = T10_Temperatures.Temperature.toFahrenheit(cAste3);
            Console.WriteLine("Celsius-asteet {0} ovat fahrenheit-asteina {1}.", cAste3, fAste3);

            double cAste4 = -15.5;
            double fAste4 = T10_Temperatures.Temperature.toFahrenheit(cAste4);
            Console.WriteLine("Celsius-asteet {0} ovat fahrenheit-asteina {1}.", cAste4, fAste4);
        }
    }
}
