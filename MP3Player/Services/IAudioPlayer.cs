using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player.Services
{
    public interface IAudioPlayer
    {
        void Play();
        void Pause();
        void Stop();
        TimeSpan GetCurrentPosition();
        TimeSpan GetTotalDuration();
        void SetVolume(float volume);
    }
}
