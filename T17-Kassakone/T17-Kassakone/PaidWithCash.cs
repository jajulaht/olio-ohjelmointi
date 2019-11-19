using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Kassakone
{
    class PaidWithCash : ITransaction
    {
        // Ominaisuudet
        private float Amount;
        private float TotalCash;

        // Maksaminen
        public void PayCash(float amount)
        {
            if (amount > 0)
            {
                Amount = amount;
                Console.WriteLine(ShowTransaction());
                TotalCash += amount;
                Console.WriteLine("Kassassa käteistä: " + ShowCash());
            }
            else
            {
                Console.WriteLine("Anna järkevä luku.");
            }
        }

        // GetAmount palauttaa maksetun määrän lukuna.
        public float GetAmount()
        {
            return Amount;
        }

        // palauttaa suomenkielisen viestin, 
        // miten maksu suoritettiin
        public string ShowTransaction()
        {
            return "Maksettu käteisellä: " + GetAmount();
        }

        // kertoo paljonko rahaa kassassa on, 
        // eli se tallentaa itselleen kaikki kassaan laitetut rahat
        public float ShowCash()
        {
            return TotalCash;
        }
    }
}
