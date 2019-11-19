using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Kassakone
{
    public class Kassa
    {
        // Ominaisuudet
        public float TotalAccount { get; set; }
        public List<ITransaction> transactions = new List<ITransaction>();

        public void KaynnistaKassa()
        {
            Console.WriteLine("Kassakone käynnistetty.");
        }

        public void PayCash(float amount)
        {
            
            
        }

        public float TotalSales()
        {
            return 0;
        }
    }
}
