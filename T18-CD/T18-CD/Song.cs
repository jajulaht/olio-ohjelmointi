using System;
namespace T18_CD
{
    public class Song
    {
        // Ominaisuudet
        public string Name { get; set; }
        public string Duration { get; set; }

        // Konstruktorit
        public Song()
        {
        }
        public Song(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }

        // Metodi tietojen tulostukselle
        public override string ToString()
        {
            return "    - " + Name + ", " + Duration;
        }
    }
}
