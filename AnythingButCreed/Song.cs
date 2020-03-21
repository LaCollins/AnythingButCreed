using System;
using System.Collections.Generic;
using System.Text;

namespace AnythingButCreed
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string artist, string name)
        {
            Name = name;
            Artist = artist;
        }

    }
}
