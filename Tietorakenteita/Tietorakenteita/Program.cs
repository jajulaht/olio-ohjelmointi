using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tietorakenteita
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testaillaan list-rakennetta, luodaan persons-lista
            List<Person> persons = new List<Person>();
            // Lisäillään listan parit persoonat
            persons.Add(
                new Person
                {
                    FirstName = "Kirsi",
                    LastName = "Kernel",
                    SocialSecurityNumber = "010190-111A"
                }
            );
            persons.Add(
                new Person
                {
                    FirstName = "Teppo",
                    LastName = "Airaksinen",
                    SocialSecurityNumber = "010191-121A"
                }
            );
            persons.Add(
                new Person
                {
                    FirstName = "Paavo",
                    LastName = "Holopainen",
                    SocialSecurityNumber = "020289-001A"
                }
            );

            // ensimmäinen listan olio
            Console.WriteLine(persons.ElementAt(0));

            // käydään kokoelma läpi
            Console.WriteLine("Käydään kokoelma läpi...");
            foreach (Person person in persons)
            {
                Console.WriteLine(person); // Voisi olla olion ToString()-metodi perässä, mutta ei tarvitse --> automaattisesti käyttöön
            }

            // järjestetään kokoelma sukunimen mukaan --> delegaatti
            persons.Sort((x,y) => x.LastName.CompareTo(y.LastName)); // Vaihtolajittelu

            // käydään kokoelma läpi
            Console.WriteLine("Käydään kokoelma läpi...");
            foreach (Person person in persons)
            {
                Console.WriteLine(person); // Voisi olla olion ToString()-metodi perässä, mutta ei tarvitse --> automaattisesti käyttöön
            }
        }
    }
}
