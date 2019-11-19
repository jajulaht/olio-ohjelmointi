using System;
namespace T10_Temperatures
{
    public class Temperature
    {
        // Tee luokka Temperature, jolla on seuraavat staattisen metodit
        public static double toCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double toFahrenheit(double celcius)
        {

            return celcius * 1.8 + 32;
        }

    }
}
