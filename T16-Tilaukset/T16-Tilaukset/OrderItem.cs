using System;
namespace T16_Tilaukset
{
    public class OrderItem
    {
        // Ominaisuudet
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        // Metodit
        public void ShowItems()
        {
            Console.WriteLine("- Item: " + ID + ", " + Name + ", " + Count + " pcs");
        }
    }
}
