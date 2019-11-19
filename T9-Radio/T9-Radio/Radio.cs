using System;
namespace T9_Radio
{
    public class Radio
    {
        // Rajat, fieldit näkyvät vain luokassa
        private int maxVol = 9;
        private int minVol = 0;
        private double minTaajuus = 2000.0;
        private double maxTaajuus = 26000.0;

        // Aksessorien apumuuttujat
        private int volume;
        private double taajuus;

        // Ominaisuudet
        public bool Virta { get; set; }

        // Tarkistus aksessoriin
        public int Volume { 
            get
            {
                return volume;
            }
            set
            {
                if(value >= minVol && value <= maxVol)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Value out of boundaries.");
                }
            }
        }

        // Tarkistus aksessoriin
        public double Taajuus {
            get
            {
                return taajuus;
            }
            set
            {
                if (value >= minTaajuus && value <= maxTaajuus)
                {
                    taajuus = value;
                }
                else
                {
                    Console.WriteLine("Value out of boundaries.");
                }
            }
        }
    }
}
