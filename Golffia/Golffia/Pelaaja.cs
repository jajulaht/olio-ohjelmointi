using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golffia
{
    class Pelaaja : Henkilö
    {
        // Ominaisuudet
        public double Tasoitus { get; set; }
        public int Jäsennumero { get; set; }
        private Bägi Bägi { get; set; }

        // Metodit
        public void LisääBägi(Bägi bägi)
        {
            Bägi = bägi;
        }

        // nro 0,...,13, koska mailoja max 14
        public void LyöMailalla(int nro)
        {
            Maila maila = Bägi.AnnaMaila(nro);
            if(maila != null)
            {
                Console.WriteLine(base.Nimi + " lyö mailalla " + maila);
            }
            else
            {
                Console.WriteLine("Ei voida lyödä mailalla, jota ei ole!");
            }
        }
        public override string ToString()
        {
            return base.ToString() + " Tasoitus " + Tasoitus + " Jäsennumero " + Jäsennumero;
        }
    }
}
