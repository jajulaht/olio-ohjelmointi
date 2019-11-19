using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Bägi
    {
        // Ominaisuudet
        public List<Maila> Mailat = new List<Maila>();

        // Metodit
        public void LisaaMaila(Maila maila)
        {
            Mailat.Add(maila);
        }
        // kohta == 0-13, 14 mailaa
        public Maila AnnaMaila(int kohta)
        {
            if(kohta < Mailat.Count)
            {
                return Mailat.ElementAt(kohta);
            } else
            {
                return null;
            }
        }
    }
}
