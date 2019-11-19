using System;
using System.Collections.Generic;

namespace T16_Tilaukset
{
    public class Order
    {
        // Ominaisuudet
        public int ID { get; set; }
        public string Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public void ShowOrderItems()
        {
            Console.WriteLine("Order {0}, {1}:", ID, Date);
            foreach (OrderItem o in OrderItems)
            {
                o.ShowItems();
            }
        }
    }
}
