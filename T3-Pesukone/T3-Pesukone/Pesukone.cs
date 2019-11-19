using System;
namespace T3_Pesukone
{
    public class Pesukone
    {
        // Ominaisuudet
        public bool VirtaPaalla { get; set; }
        public String Ohjelma { get; set; }
        public bool Linkous { get; set; }
        public int LinkousRPM { get; set; }

        // Oletuskonstruktori
        public Pesukone()
        {
        }

        // Parametrillinen konstruktori
        public Pesukone(bool virta, int ohjelma)
        {
            // Parametrina tuotu tieto viedään luokan ominaisuuteen
            VirtaPaalla = virta;
            Ohjelma = OhjelmaVal(ohjelma);
        }

        // Toinen parametrillinen konstruktori
        public Pesukone(bool virta, int ohjelma, bool linkous)
        {
            // Parametrina tuotu tieto viedään luokan ominaisuuteen
            VirtaPaalla = virta;
            Ohjelma = OhjelmaVal(ohjelma);
            Linkous = linkous;
        }

        // Kolmas parametrillinen konstruktori
        public Pesukone(bool virta, int ohjelma, bool linkous, int linkousNop)
        {
            // Parametrina tuotu tieto viedään luokan ominaisuuteen
            VirtaPaalla = virta;
            Ohjelma = OhjelmaVal(ohjelma);
            Linkous = linkous;
            LinkousRPM = linkousNop;
        }

        // Toiminnot eli metodit
        public string OhjelmaVal(int val)
        {
            string ohjelma;
            switch(val)
            {
                case 1:
                    ohjelma = "Hienopesu";
                    return ohjelma;
                case 2:
                    ohjelma = "Kirjopesu";
                    return ohjelma;
                case 3:
                    ohjelma = "Valkopesu";
                    return ohjelma;
                // Voiko laittaa default-arvon, jos annetaan joku muu val kuin 1-3?
                default:
                    return "Hienopesu";
            }
        }

        public void NaytaTiedot()
        {
            Console.WriteLine("Ohjelma on: " + Ohjelma);
            if (Linkous)
            {
                Console.WriteLine("Linkous: Päällä");
                Console.WriteLine("Linkouksen nopeus: " + LinkousRPM + " kierrosta");
            }
            else
            {
                Console.WriteLine("Linkous: Pois päältä");
            }
        }
        public void Lopetus()
        {
            Console.WriteLine("Ohjelma valmis, kone sammuuu.");
        }
    }
}
