using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP3Player.Models;

using NAudio.Wave;

namespace MP3Player.Services
{
    public class AudioPlayer : IAudioPlayer, IDisposable
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string currentSongPath = "";
        private bool isPaused = false;

        public void Play()
        {
            if (string.IsNullOrEmpty(currentSongPath))
            {
                return;
            }

            try
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(currentSongPath);
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
                else if (isPaused)
                {
                    outputDevice.Play();
                    isPaused = false;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Pause()
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                isPaused = true;
            }
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                DisposeAudio();
            }
            currentSongPath = "";
            isPaused = false;
        }

        public void SetCurrentSong(string songPath)
        {
            if (currentSongPath != songPath)
            {
                Stop();
                currentSongPath = songPath;
            }
        }

        public TimeSpan GetCurrentPosition() 
        {
            return audioFile?.CurrentTime ?? TimeSpan.Zero;
        }

        public TimeSpan GetTotalDuration()
        {
            return audioFile?.TotalTime ?? TimeSpan.Zero;
        }

        public void SetVolume(float volume)
        {
            if (audioFile != null)
            {
                volume = (volume < 0.0f) ? 0.0f : (volume > 1.0f) ? 1.0f : volume;
                audioFile.Volume = volume;
            }
        }

        private void DisposeAudio()
        {
            audioFile?.Dispose();
            audioFile = null;
            outputDevice?.Dispose();
            outputDevice = null;
        }

        public void Dispose() => DisposeAudio();
    }
}
