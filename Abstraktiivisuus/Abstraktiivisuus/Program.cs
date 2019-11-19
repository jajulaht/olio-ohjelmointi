using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktiivisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraktista luokasta ei voi luoda oliota
            // DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My circle!";
            circle.Draw();
            Console.WriteLine("Circle name is {0}", circle.Name);

            Square square = new Square();
            square.Name = "My square!";
            square.Draw();
            Console.WriteLine("Square name is {0}", square.Name);

            // Monimuotoisuus
            // - lista sisältää DrawingObjecteja
            // - circle ja square ovat sen aliluokan olioita
            // - eli voivat mennä tähän listaan
            List<DrawingObject> objects = new List<DrawingObject>();
            objects.Add(circle);
            objects.Add(square);

            // Käydään lista läpi
            Console.WriteLine("Listan alkiot piirtävät:");
            foreach(DrawingObject drawingObject in objects)
            {
                drawingObject.Draw();
            }
        }
    }
}
