using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    class Person
    {
        // julkiset ominaisuudet
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        // konstruktorit
        public Person()
            {
            }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        
        // julkiset metodit
        public void PersonMethod()
        {
            Console.WriteLine("PersonMethod");
        }

        // Korvaaminen eli ylikirjoittaminen
        // ylikirjoitetaan Object-luokan ToString(), joka tulostaa luokan nimen
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + Age + " " + PhoneNumber;
        }
    }
}
