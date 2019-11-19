using System;
using System.Collections.Generic;

namespace T18_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan kappaleita
            Song song1 = new Song { Name = "Shudder Before the Beautiful", Duration = "6:29" };
            Song song2 = new Song { Name = "Weak Fantasy", Duration = "5:23" };
            Song song3 = new Song { Name = "Elan", Duration = "4:45" };
            Song song4 = new Song { Name = "Yours Is an Empty Hope", Duration = "5:34" };

            // Luodaan CD
            CD cd = new CD();

            // Lisätään sille ominaisuuksia
            cd.Name = "Endless Forms Most Beautiful (part)";
            cd.Artist = "Nightwish";
            cd.Songs = new List<Song>();

            // Lisätään kappaleet listaan
            cd.Songs.Add(song1);
            cd.Songs.Add(song2);
            cd.Songs.Add(song3);
            cd.Songs.Add(song4);

            cd.ShowInfo();
        }
    }
}
