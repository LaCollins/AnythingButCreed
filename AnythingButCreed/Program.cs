using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>();

            allSongs.Add(new Song("VNV Nation", "Everything"));
            allSongs.Add(new Song("The Birthday Massacre", "One"));
            allSongs.Add(new Song("FGFC820", "Society"));
            allSongs.Add(new Song("Creed", "Everybody Hates Me"));
            allSongs.Add(new Song("Feint", "Vagrant"));
            allSongs.Add(new Song("Grendel", "Wheels in Motion"));
            allSongs.Add(new Song("Kamelot", "Phantom Devine"));
            allSongs.Add(new Song("Creed", "Sucking So Hard It Hurts"));
            allSongs.Add(new Song("Nightwish", "The Islander"));
            allSongs.Add(new Song("Within Temptation", "Angels"));
            allSongs.Add(new Song("Suicide Commando", "Die Motherfucker Die"));
            allSongs.Add(new Song("God Module", "The Source"));

            goodSongs = allSongs.Where(bandName => bandName.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
