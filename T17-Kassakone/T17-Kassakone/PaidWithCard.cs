using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Kassakone
{
    class PaidWithCard : ITransaction
    {
        // Ominaisuudet
        public float Amount { get; set; }
        public float Total { get; set; }

        // Maksaminen
        public void PayCard(float amount)
        {
            Amount = amount;
            ShowTransaction();
            Total += amount;
            ShowAccount();
        }

        // GetAmount palauttaa maksetun määrän lukuna.
        public float GetAmount()
        {
            throw new NotImplementedException();
        }

        // palauttaa suomenkielisen viestin, 
        // miten maksu suoritettiin
        public string ShowTransaction()
        {
            return "Pankkisiirto tilille: ";
        }


        // kertoo paljonko rahaa tillä on, 
        // eli se tallentaa itselleen kaikki kassaan laitetut rahat
        public float ShowAccount()
        {
            return Total;
        }
    }
}
