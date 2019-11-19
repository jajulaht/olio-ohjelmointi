using System;
using System.Collections.Generic;

namespace T18_CD
{
    public class CD
    {
        // Ominaisuudet
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs { get; set; }

        // Metodi tietojen tulostamiseen
        public void ShowInfo()
        {
            Console.WriteLine("CD data:");
            Console.WriteLine("  name: {0}", Name);
            Console.WriteLine("  artist: {0}", Artist);
            Console.WriteLine("  songs:");
            foreach(Song s in Songs)
            {
                Console.WriteLine(s.ToString());
            }

        }
    }
}
