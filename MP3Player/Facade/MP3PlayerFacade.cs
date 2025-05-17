using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Player.Models;
using MP3Player.Services;
using MP3Player.Utils;

namespace MP3Player.Facade
{
    public class MP3PlayerFacade
    {
        private AudioPlayer audioPlayer;
        private PlaylistManager playlistManager;

        public MP3PlayerFacade()
        {
            audioPlayer = new AudioPlayer();
            playlistManager = new PlaylistManager();
        }

        public void Play()
        {
            var song = playlistManager.GetCurrentSong();
            audioPlayer.Play(song);
        }

        public void Pause()
        {
            audioPlayer.Pause();
        }

        public void Next()
        {
            playlistManager.NextSong();
            Play();
        }

        public void AddSong()
        {
            var songPath = FileDialogUtils.OpenFile();
            if (!string.IsNullOrEmpty(songPath))
                playlistManager.AddSong(new Song(songPath));
        }
    }
}
