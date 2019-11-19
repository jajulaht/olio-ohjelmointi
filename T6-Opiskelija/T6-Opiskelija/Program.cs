using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Opiskelija-olio
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Etunimi = "Paavo";
            opiskelija.Sukunimi = "Holopainen";
            opiskelija.OpiskelijaNumero = "N0464";
            opiskelija.Pääaine = "Kognitiotiede";
            opiskelija.Katuosoite = "Piipputori";
            opiskelija.Postinumero = "40100";
            opiskelija.Paikkakunta = "Jyväskylä";
            opiskelija.Opintopisteet = 500;
            // opiskelija.NaytaTiedot();

            // Luodaan toinen Opiskelija-olio
            Opiskelija opiskelija2 = new Opiskelija();
            opiskelija2.Etunimi = "Liisa";
            opiskelija2.Sukunimi = "Holopainen";
            opiskelija2.OpiskelijaNumero = "N0465";
            opiskelija2.Pääaine = "Tietojärjestelmätiede";
            opiskelija2.Katuosoite = "Piipputori";
            opiskelija2.Postinumero = "40100";
            opiskelija2.Paikkakunta = "Jyväskylä";
            opiskelija2.Opintopisteet = 500;
            // opiskelija2.NaytaTiedot();

            // Luodaan kolmas Opiskelija-olio
            Opiskelija opiskelija3 = new Opiskelija();
            opiskelija3.Etunimi = "Matti";
            opiskelija3.Sukunimi = "Mainio";
            opiskelija3.OpiskelijaNumero = "N0466";
            opiskelija3.Pääaine = "IT-insinööri";
            opiskelija3.Katuosoite = "Torikatu";
            opiskelija3.Postinumero = "40100";
            opiskelija3.Paikkakunta = "Jyväskylä";
            opiskelija3.Opintopisteet = 200;
            // opiskelija3.NaytaTiedot();

            // Luodaan neljäs Opiskelija-olio
            Opiskelija opiskelija4 = new Opiskelija();
            opiskelija4.Etunimi = "Jussi";
            opiskelija4.Sukunimi = "Juonio";
            opiskelija4.OpiskelijaNumero = "N0467";
            opiskelija4.Pääaine = "Musiikkitiede";
            opiskelija4.Katuosoite = "Satamakatu";
            opiskelija4.Postinumero = "40100";
            opiskelija4.Paikkakunta = "Jyväskylä";
            opiskelija4.Opintopisteet = 250;
            // opiskelija4.NaytaTiedot();

            // Luodaan viides Opiskelija-olio
            Opiskelija opiskelija5 = new Opiskelija();
            opiskelija5.Etunimi = "Linda";
            opiskelija5.Sukunimi = "Liukas";
            opiskelija5.OpiskelijaNumero = "N0468";
            opiskelija5.Pääaine = "Tietotekniikka";
            opiskelija5.Katuosoite = "Satamakatu 2";
            opiskelija5.Postinumero = "40100";
            opiskelija5.Paikkakunta = "Jyväskylä";
            opiskelija5.Opintopisteet = 220;
            // opiskelija5.NaytaTiedot();

            // Taulukko opiskelijoille
            Opiskelija[] Opiskelijat = new Opiskelija[5];
            Opiskelijat[0] = opiskelija;
            Opiskelijat[1] = opiskelija2;
            Opiskelijat[2] = opiskelija3;
            Opiskelijat[3] = opiskelija4;
            Opiskelijat[4] = opiskelija5;

            // Tulostetaan silmukassa
            for (int i = 0; i < Opiskelijat.Length; i++)
            {
                Opiskelijat[i].NaytaTiedot();
            }
        }
    }
}
