using System;
using System.Collections.Generic;

namespace T16_Tilaukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olioita
            Customer customer1 = new Customer("Etunimi1","Sukunimi1", "Katuosoite 1", "40101", "Kaupunki1");
            customer1.Orders = new List<Order>();
            Customer customer2 = new Customer("Etunimi2", "Sukunimi2", "Katuosoite 2", "40102", "Kaupunki2");
            customer2.Orders = new List<Order>();
            Customer customer3 = new Customer("Etunimi3", "Sukunimi3", "Katuosoite 3", "40103", "Kaupunki3");
            customer3.Orders = new List<Order>();
            Customer customer4 = new Customer("Etunimi4", "Sukunimi4", "Katuosoite 4", "40104", "Kaupunki4");
            customer4.Orders = new List<Order>();

            OrderItem item1 = new OrderItem();
            item1.ID = 1;
            item1.Name = "TheItem1";
            item1.Count = 1;

            OrderItem item2 = new OrderItem();
            item2.ID = 2;
            item2.Name = "TheItem2";
            item2.Count = 2;

            OrderItem item3 = new OrderItem();
            item3.ID = 3;
            item3.Name = "TheItem3";
            item3.Count = 1;

            Order order1 = new Order();
            order1.ID = 1;
            order1.Date = "22.05.2019";
            order1.OrderItems = new List<OrderItem>();
            order1.OrderItems.Add(item1);
            order1.OrderItems.Add(item2);

            Order order2 = new Order();
            order2.ID = 2;
            order2.Date = "22.05.2019";
            order2.OrderItems = new List<OrderItem>();
            order2.OrderItems.Add(item1);
            order2.OrderItems.Add(item2);

            Order order3 = new Order();
            order3.ID = 3;
            order3.Date = "22.05.2019";
            order3.OrderItems = new List<OrderItem>();
            order3.OrderItems.Add(item2);
            order3.OrderItems.Add(item3);

            Order order4 = new Order();
            order4.ID = 4;
            order4.Date = "22.05.2019";
            order4.OrderItems = new List<OrderItem>();
            order4.OrderItems.Add(item1);
            order4.OrderItems.Add(item2);

            Order order5 = new Order();
            order5.ID = 5;
            order5.Date = "22.05.2019";
            order5.OrderItems = new List<OrderItem>();
            order5.OrderItems.Add(item1);

            customer1.Orders.Add(order1);
            customer1.Orders.Add(order5);
            customer2.Orders.Add(order2);
            customer3.Orders.Add(order3);
            customer4.Orders.Add(order4);

            customer1.ShowOrders();
            customer2.ShowOrders();
            customer3.ShowOrders();
            customer4.ShowOrders();
        }
    }
}
