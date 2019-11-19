using System;
using System.Collections.Generic;

namespace T16_Tilaukset
{
    public class Customer
    {
        // Ominaisuudet
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; } // Lista tilauksista

        // Konstruktorit
        public Customer()
        {
        }
        public Customer(string firstname, string lastname, string address, string postcode, string city)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.PostCode = postcode;
            this.City = city;
        }

        // Metodit
        public void ShowOrders()
        {
            Console.WriteLine("CUSTOMER {0} {1}", FirstName, LastName);
            Console.WriteLine("Orders");
            Console.WriteLine("--------");
            foreach (Order o in Orders)
            {
                o.ShowOrderItems();
            }
            Console.WriteLine("");
        }
    }
}
