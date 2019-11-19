using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23_LajitteluA
{
    // Luokka tallennettaville tiedoille
    public class CountedName
    {
        // Ominaisuudet
        public string name { get; set; }
        public int amount { get; set; }
    }

    class Program
    {
        // Taulukko teksteille
        public static string[] lines;

        static void Main(string[] args)
        {
            // Tiedoston sijainti
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Tiedosto pitäisi löytyä
            // (mydocpath + @"\documents\nimet.txt")
            // Mac OS X ei ymmärtänyt takakenoviivaa
            // Vaikka tarkistus tiedostolle, try/catch
            try
            {
                // Luetaan tekstitiedosto taulukkoon, jos olemassa
                if (File.Exists(mydocpath + @"/documents/nimet.txt"))
                {
                    lines = System.IO.File.ReadAllLines(mydocpath + @"/documents/nimet.txt");
                }
                else
                {
                    Console.WriteLine("Tiedostoa ei ole annetussa sijainnissa.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Lista lasketuille nimille
            List<CountedName> names = new List<CountedName>();

            // Lasketaan nimien esiintymät
            foreach (string line in lines)
            {
                if (DoubleCheck(line)) // Tarkastetaan, ettei tule duplikaatteja
                {
                    int counted = 0; // Laskuri
                    string compName = line;
                    foreach (string compLine in lines)
                    {
                        if (string.Compare(compName, compLine) == 0)
                        {
                            counted++;
                        }
                    }
                    CountedName cn = new CountedName { name = compName, amount = counted };
                    names.Add(cn);
                }
            }

            // Aliohjelma tarkistukseen, onko nimi jo laskettu
            bool DoubleCheck(string name)
            {
                foreach (CountedName cn in names)
                {
                    if(string.Compare(cn.name, name) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            // Tulostus
            Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä", lines.Length, names.Count);
            foreach (CountedName cn in names)
            {
                Console.WriteLine("Nimi {0} esiintyy {1} kertaa", cn.name, cn.amount);
            }
        }
    }
}
