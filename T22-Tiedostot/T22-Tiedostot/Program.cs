using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22_Tiedostot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tiedoston sijainti
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Luettu rivi käyttäjältä
            string line;

            // Kirjoitetaan tiedostoon
            try
            {
                // c:\users\Janne Lahtinen\Documents\rivit.txt
                // Using-lause rajaa StreamWriter-luokan olion näkymään ja 
                // toimimaan ainoastaan using-lauseen määrittämien {}-sulkujen sisälle. 
                // Tämän jälkeen sille kutsutaan automaattisesti Dispose()-metodia, 
                // joka vaputtaa ko. olion käyttämät resurssit välittömästi. 
                // Objekti on myös "read-only" tilassa ja siihen siis voida enää tehdä määrittelyjä, 
                // vaan sitä voidaan ainoastaan käyttää (using).
                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\rivit.txt"))
                // using (StreamWriter outputFile = new StreamWriter(@"\rivit.txt")) 
                // --> UnauthorizedException, ei ole oikeutta kirjoittaa juureen
                {
                    do
                    {
                        Console.Write("Give a text line (enter ends): ");
                        line = Console.ReadLine();
                        if (line.Length != 0) outputFile.WriteLine(line);
                    } while (line.Length != 0);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Tulostetaan tiedoston sisältö
            Console.WriteLine("File contents:");

            // Muuttuja teksteille, luetaan data siihen, TRY-lohkoon
            try
            {
                string texts = File.ReadAllText(mydocpath + @"\rivit.txt");
                Console.WriteLine(texts);
            } catch(FileNotFoundException)
            {
                Console.WriteLine("File not found :-(");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
