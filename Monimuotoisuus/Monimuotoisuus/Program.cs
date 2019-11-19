using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monimuotoisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olio Animal-luokasta
            Animal animal = new Animal();
            animal.Talk();
            Console.WriteLine("Animal has {0} legs.", animal.Legs);
            Console.WriteLine("Animal type is {0}.", animal.GetType());

            // Monimuotoisuus eli polymorphism
            // Olion tunniste voi sisältää olio-luokan itsensä tai aliluokan olion!!!!!!
            Animal animal2 = new Dog();
            animal2.Talk(); // Vuh vuh! --> Ominaisuudet ja metodit olion omasta luokasta

            Console.WriteLine("Animal has {0} legs.", animal2.Legs);
            Console.WriteLine("Animal type is {0}.", animal2.GetType());

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Chicken());

            // käydään eläimet läpi
            foreach(Animal ani in animals)
            {
                ani.Talk();
            }

            // TYYPPIMUUNNOKSIA

            // implicit casting: "turvallinen", tietoa ei häviä
            int i = 54321;
            double d = i; // Tyyppimuunnos integer --> double
            Console.WriteLine("Luku on " + d);

            Console.WriteLine("Int minimi " + int.MinValue);
            Console.WriteLine("Int maksimi " + int.MaxValue);

            Console.WriteLine("Double minimi " + double.MinValue);
            Console.WriteLine("Double maksimi " + double.MaxValue);

            // eksplicit casting: tietoa saattaa hävitä
            double d2 = 65432.099121;
            int i2 = (int)d2;
            Console.WriteLine("Luku on " + i2);

            double d3 = 65432987459873459873495873458.099121;
            int i3 = (int)d3;
            Console.WriteLine("Luku on " + i3);

            // merkkijono numeroksi, tyyppimuunnoksia tehdään GUI-luvuista paljon
            Console.WriteLine("Anna luku > ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out int number);
            if(result)
            {
                Console.WriteLine("Luku on " + number);
            }

            // Numero merkkijonoksi
            int luku = 1000;
            string merkkijonoluku = luku.ToString(); // 1000 --> "1000"
            Console.WriteLine("Luku on " + merkkijonoluku);

            // Olioiden välinen tyyppimuunnos
            Animal ani3 = new Animal();
            Dog dog3 = new Dog();

            ani3 = dog3; // Monimuotoisuus --> ei tyyppimuunnosta

            // Dog dog4 = (Dog)ani3; // Ei voi olla Chicken
            // dog4.Talk();

            if(ani3 is Dog) // Tarkistetaan onko tunnisteessa koiraluokan olio
            {
                Dog dog4 = (Dog)ani3;
                dog4.Talk();
            }
        }
    }
}
