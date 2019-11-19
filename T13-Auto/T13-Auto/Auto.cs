using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Auto
{
    class Auto
    {
        // Suojattu ominaisuus
        private const int maxRenkaidenLkm = 10;

        
        // Ominaisuudet
        public string Merkki { get; set; }
        public string Malli { get; set; }

        // Suojattu lista
        private List<Rengas> Renkaat = new List<Rengas>();

        // Metodi, lisää renkaita listaan
        public void LisaaRengas(Rengas rengas)
        {
            if(Renkaat.Count < maxRenkaidenLkm)
            {
                Renkaat.Add(rengas);
            }
            else
            {
                Console.WriteLine("Sorry - autoon ei mahdu enää renkaita.");
            }
        }

        public void TulostaAutonTiedot()
        {
            Console.WriteLine("Merkki: " + Merkki + " , malli: " + Malli);
            // Käydään listan renkaat läpi rengas kerrallaan
            foreach(Rengas rengas in Renkaat)
            {
                Console.WriteLine(rengas); // Ajaa renkaan toString()-metodin
            }
        }

        ~Auto()
        {
            Console.WriteLine("Auto on tuhottu!");
        }
    }
}
