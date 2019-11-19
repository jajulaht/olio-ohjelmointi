using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Tank
{
    class Tank
    {
        // Sisäiset muuttujat
        private readonly int minCrew = 2;
        private readonly int maxCrew = 6;
        private readonly float speedmax = 100;
        private readonly float speedmin = 0;
        private string name;
        private string type;
        private int crewcount;
        private float speed = 0; // Oletuksena nolla

        // Ominaisuudet, käyttävät sisäisiä muuttujia
        // Ominaisuudet Name ja Type ovat luettavissa
        // sekä muutettavissa ilman rajoituksia
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        // Ominaisuus CrewCount on luettavissa ja
        // asetettavissa
        public int CrewCount 
        {
            get 
            {
                return crewcount;
            } 
            set 
            {
                // Tarkistus: min-max
                if (value >= minCrew && value <= maxCrew)
                {
                    crewcount = value;
                }
                else
                {
                    Console.WriteLine("Selected value is not valid.");
                }
            } 
        }
        // Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa
        // suoraan, mutta sen arvon voi lukea
        public float Speed {
            get
            {
                return speed;
            }
        }
        // SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena
        // pysyvästi arvoon 100
        public float SpeedMax {
            get
            {
                return speedmax;
            }
        }

        // Metodit
        // Metodi palauttaa arvon true, jos voi kiihdyttää
        public bool AccerelateTo(float arvo)
        {
            if(speed + arvo <= speedmax)
            {
                speed += arvo;
                return true;
            }
            else
            {
                // Ei muuta nopeutta
                return false;
            }
        }
        // Metodi palauttaa arvon true, jos voi hidastaa
        public bool SlowTo(float arvo)
        {
            if (speed - arvo >= speedmin)
            {
                speed -= arvo;
                return true;
            }
            else
            {
                // Ei muuta nopeutta
                return false;
            }
        }
    }
}
