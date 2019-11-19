using System;
using System.Collections.Generic;

namespace T14_Latka
{
    class Program
    {
        static void Main(string[] args)
        {

            // Alustetaan olioita
            Pelaaja pelaaja = new Pelaaja();
            pelaaja.Etunimi = "Paavo";
            pelaaja.Sukunimi = "Holopainen";
            pelaaja.Pelipaikka = "h";
            pelaaja.Katisyys = 'L';

            Pelaaja pelaaja2 = new Pelaaja();
            pelaaja2.Etunimi = "Reijo";
            pelaaja2.Sukunimi = "Rääväsuu";
            pelaaja2.Pelipaikka = "p";
            pelaaja2.Katisyys = 'R';

            Pelaaja pelaaja3 = new Pelaaja();
            pelaaja3.Etunimi = "Jeppe";
            pelaaja3.Sukunimi = "Jahnukainen";
            pelaaja3.Pelipaikka = "mv";
            pelaaja3.Katisyys = 'R';

            Pelaaja pelaaja4 = new Pelaaja();
            pelaaja4.Etunimi = "Matti";
            pelaaja4.Sukunimi = "Mainio";
            pelaaja4.Pelipaikka = "h";
            pelaaja4.Katisyys = 'L';

            Pelaaja pelaaja5 = new Pelaaja();
            pelaaja5.Etunimi = "Jussi";
            pelaaja5.Sukunimi = "Juonio";
            pelaaja5.Pelipaikka = "h";
            pelaaja5.Katisyys = 'R';

            Pelaaja pelaaja6 = new Pelaaja();
            pelaaja6.Etunimi = "Paavo";
            pelaaja6.Sukunimi = "Holopainen";
            pelaaja6.Pelipaikka = "h";
            pelaaja6.Katisyys = 'L';

            Pelaaja pelaaja7 = new Pelaaja();
            pelaaja7.Etunimi = "Janne";
            pelaaja7.Sukunimi = "Lahtinen";
            pelaaja7.Pelipaikka = "h";
            pelaaja7.Katisyys = 'L';

            Pelaaja pelaaja8 = new Pelaaja();
            pelaaja8.Etunimi = "Reijo";
            pelaaja8.Sukunimi = "Rokkaa";
            pelaaja8.Pelipaikka = "p";
            pelaaja8.Katisyys = 'R';

            Pelaaja pelaaja9 = new Pelaaja();
            pelaaja9.Etunimi = "Jeppe";
            pelaaja9.Sukunimi = "Joukahainen";
            pelaaja9.Pelipaikka = "mv";
            pelaaja9.Katisyys = 'R';

            Pelaaja pelaaja10 = new Pelaaja();
            pelaaja10.Etunimi = "Martti";
            pelaaja10.Sukunimi = "Mainio";
            pelaaja10.Pelipaikka = "h";
            pelaaja10.Katisyys = 'L';

            Pelaaja pelaaja11 = new Pelaaja();
            pelaaja11.Etunimi = "Jussi";
            pelaaja11.Sukunimi = "Parviainen";
            pelaaja11.Pelipaikka = "h";
            pelaaja11.Katisyys = 'R';

            Pelaaja pelaaja12 = new Pelaaja();
            pelaaja12.Etunimi = "Paavo";
            pelaaja12.Sukunimi = "Petturi";
            pelaaja12.Pelipaikka = "h";
            pelaaja12.Katisyys = 'L';

            // Seura-oliot
            Seura seura = new Seura();
            seura.Nimi = "JYP";
            seura.Kaupunki = "Jyväskylä";
            seura.Pelaajat = new List<Pelaaja>(); // Alustetaan seuran lista
            seura.Pelaajat.Add(pelaaja);
            seura.Pelaajat.Add(pelaaja2);
            seura.Pelaajat.Add(pelaaja3);
            seura.Pelaajat.Add(pelaaja4);
            seura.Pelaajat.Add(pelaaja5);
            seura.Pelaajat.Add(pelaaja6);

            Seura seura2 = new Seura();
            seura2.Nimi = "HIFK";
            seura2.Kaupunki = "Helsinki";
            seura2.Pelaajat = new List<Pelaaja>(); // Alustetaan seuran lista
            seura2.Pelaajat.Add(pelaaja7);
            seura2.Pelaajat.Add(pelaaja8);
            seura2.Pelaajat.Add(pelaaja9);
            seura2.Pelaajat.Add(pelaaja10);
            seura2.Pelaajat.Add(pelaaja11);
            seura2.Pelaajat.Add(pelaaja12);

            Console.WriteLine("LIIGAJOUKKUEET");
            Console.WriteLine("---------------");
            seura.NaytaTiedot();
            seura2.NaytaTiedot();
        }
    }
}
