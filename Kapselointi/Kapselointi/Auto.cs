using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselointi
{
    class Auto
    {
        // Fields, private eli ei näy luokan ulkopuolelle
        private readonly int maxSpeed = 100;
        private int nopeus;

        // Ominaisuudet
        public string Merkki { get; set; }
        public int Nopeus {
            get
            {
                return nopeus; // Palautetaan auton "todellinen" nopeus
            }
            set
            {
                // Tsekataan, onko haluttu nopeus eli value hyväksytty
                if (value <= maxSpeed) nopeus = value;
                else
                {
                    // Liikaa nopeutta, rajoitetaan maksimiin
                    nopeus = maxSpeed;
                    Console.WriteLine("Liikaa nopeutta, laitettu maksimi.");
                }
            }
        } // Julkinen ominaisuus, jota voi yrittää muuttaa

        // Konstruktorit
        public Auto()
        {
        }

        // PO: Auto auto = new Auto("Audi", 300);
        public Auto(string merkki, int nopeus)
        {
            Merkki = merkki;
            Nopeus = nopeus; // Meneekö tässä auto rikki
        }

        // Metodeja

        // Toiminto luokan sisällä, joka riippuu auton nopeudesta
        private void SyotaBensaa()
        {
            // Käytä täällä aina nopeus-muuttujaa EI Nopeus-muutujaa
        }

        public void Kiihdyta(int arvo)
        {
            // Ei suoraan suojattuun fieldiin!!!
            // nopeus = nopeus + arvo;
            Nopeus = nopeus + arvo; // Kokeillaan set-aksessorin kautta muutta nopeutta
        }
    }
}
