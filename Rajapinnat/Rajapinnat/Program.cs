using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Miuku";
            Console.WriteLine("Cat {0}: {1}", cat.Name, cat.Talk());

            Dog dog = new Dog();
            dog.Name = "Luffe";
            Console.WriteLine("Dog {0}: {1}", dog.Name, dog.Talk());
        }
    }
}
