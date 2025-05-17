using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.Models
{
    public class Song
    {
        public string FilePath { get; set; }

        public Song(string path)
        {
            FilePath = path;
        }
    }
}
