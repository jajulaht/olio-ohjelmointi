using System;
using System.Collections.Generic;

namespace T15_Jaakaappi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olioita
            Kiintea kiintea1 = new Kiintea();
            kiintea1.Nimi = "Kukkakaali";
            kiintea1.ViimKayttoPaiva = "30.05.2019";
            kiintea1.Kappalemaara = 1;

            Kiintea kiintea2 = new Kiintea();
            kiintea2.Nimi = "Paprika";
            kiintea2.ViimKayttoPaiva = "29.05.2019";
            kiintea2.Kappalemaara = 2;

            Neste neste1 = new Neste();
            neste1.Nimi = "Kivennäisvesi";
            neste1.ViimKayttoPaiva = "31.12.2019";
            neste1.Tilavuus = 1;

            Neste neste2 = new Neste();
            neste2.Nimi = "Olut";
            neste2.ViimKayttoPaiva = "31.12.2019";
            neste2.Tilavuus = 0.33;

            Pakattu pakattu = new Pakattu();
            pakattu.Nimi = "Jauheliha";
            pakattu.ViimKayttoPaiva = "26.05.2019";
            pakattu.Paino = 400;

            Jaakaappi jaakaappi = new Jaakaappi();
            jaakaappi.Nimi = "AEG";
            jaakaappi.Elintarvikkeet = new List<Elintarvike>(); // Alustetaan jääkaapin lista
            jaakaappi.Elintarvikkeet.Add(kiintea1);
            jaakaappi.Elintarvikkeet.Add(kiintea2);
            jaakaappi.Elintarvikkeet.Add(neste1);
            jaakaappi.Elintarvikkeet.Add(neste2);
            jaakaappi.Elintarvikkeet.Add(pakattu);

            jaakaappi.NaytaTiedot();
        }
    }
}
