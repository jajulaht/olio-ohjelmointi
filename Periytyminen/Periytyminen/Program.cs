using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan olio Person-luokasta
            Person person = new Person("Kirsi", "Kernel");
            person.Address = "Piippukatu";
            person.Age = 20;
            person.PhoneNumber = "050345678";
            Console.WriteLine(person.ToString());

            // luodaan yksi opettaja
            Teacher teacher = new Teacher("Matti", "Tehokas", "D404");
            teacher.Address = "Opettajantie 1";
            teacher.Age = 50;
            teacher.PhoneNumber = "050234789";
            Console.WriteLine(teacher.ToString());
        }
    }
}
