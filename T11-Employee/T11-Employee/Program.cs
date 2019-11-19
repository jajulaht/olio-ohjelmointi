using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan Employee- ja Boss-olioita
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;

            Boss boss = new Boss();
            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;

            Employee employee2 = new Employee();
            employee2.Name = "Kirsi Kernel";
            employee2.Profession = "Principal Teacher";
            employee2.Salary = 2200;

            // Kootaan listaan
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(boss);
            employees.Add(employee2);

            // Tulostetaan lista yksi kerrallaan
            foreach(Employee e in employees)
            {
                e.NaytaTiedot();
            }
        }
    }
}
