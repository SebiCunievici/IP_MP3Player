using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Player.Models;

namespace MP3Player.Services
{
    public class PlaylistManager
    {
        private Playlist playlist;
        private int currentIndex = 0;

        public PlaylistManager()
        {
            playlist = new Playlist();
        }

        public void AddSong(Song song)
        {
            playlist.Songs.Add(song);
        }

        public Song GetCurrentSong()
        {
            if (playlist.Songs.Count == 0) return null;
            return playlist.Songs[currentIndex];
        }

        public void NextSong()
        {
            if (playlist.Songs.Count == 0) return;
            currentIndex = (currentIndex + 1) % playlist.Songs.Count;
        }
    }
}
