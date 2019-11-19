using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanakirjaTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan sanakirja
            // key = string
            // value = Person object
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            // Luodaan muutamia persoonia 
            Person person1 = new Person { FirstName = "Kirsi", LastName = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person person2 = new Person { FirstName = "Matti", LastName = "Husso", SocialSecurityNumber = "020292-222A" };
            Person person3 = new Person { FirstName = "Teppo", LastName = "Vuolle", SocialSecurityNumber = "030393-333A" };

            //ja lisätään kokoelmaan
            persons.Add(person1.SocialSecurityNumber, person1);
            persons.Add(person2.SocialSecurityNumber, person2);
            persons.Add(person3.SocialSecurityNumber, person3);

            // find person with key
            string key = "020292-222A";
            if (persons.ContainsKey(key))
            {
                Console.WriteLine("Person with social security number {0} is {1}.", key, persons[key].FirstName);
                // output
                // Person with social security number 020292-222A is Matti.
            }
        }
    }
}
