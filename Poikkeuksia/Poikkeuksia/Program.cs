using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poikkeuksia
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100;
            int number2 = 6;

            try
            {
                int result = number1 / number2;
                Console.WriteLine("Result is {0}", result);
            } catch(DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            } finally
            {
                Console.WriteLine("Finally here!");
            }
            

            /* Tämä on oikea ratkaisu korjata tilanne
             * -------------------------------------
            if (number2 != 0)
            {
                int result = number1 / number2;
                Console.WriteLine("Result is {0}", result);
            }
            else
            {
                Console.WriteLine("Ei voi jakaa nollalla!");
            }

            \n stringissä enter
            \t stringissä tab
            \\ stringissä \
            @ ennen stringiä kertoo, että \ on normaali merkki
            esimerkiksi levylle kirjoitettaessa (@"C:\test.file")

            */



            /*
            Alla olevassa ongelmana Parse,
            pitäisi laittaa TryParse, niin ei kaadu
            muita kuin numero kirjoitettuna!
            
            Console.Write("Give a number : ");
            string line = Console.ReadLine();
            int number = int.Parse(line);
            */
        }
    }
}
