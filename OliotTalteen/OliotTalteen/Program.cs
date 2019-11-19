using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OliotTalteen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olio, käytetään konstruktorin ja aksessorien
            // yhdistelmää
            Person person = new Person
            {
                FirstName = "Kirsi",
                LastName = "Kernel"
            };

            // Käytetään monimuotoisuutta --> ei tarvitse laittaa FileStream
            Stream writeStream = new FileStream(
                "Person.bin", FileMode.Create,
                FileAccess.Write, FileShare.None
                );

            // Formatointi-olio
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, person);
            writeStream.Close();

            // Luetaan Person levyltä
            // Avataan virta lukemista varten
            Stream readStream = new FileStream(
                "Person.bin", FileMode.Open,
                FileAccess.Read, FileShare.None
                );

            // Tyyppimuunnetaan Person-olioksi
            // Olisi hyvä tutkia, tuleeko oikeita olioita
            // ettei tule poikkeusta muunnoksesta
            Person newPerson = (Person) formatter.Deserialize(readStream);

            Console.WriteLine("Person is {0} {1}", newPerson.FirstName, newPerson.LastName);
            readStream.Close();
        }
    }
}
