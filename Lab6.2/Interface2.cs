using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._2
{
    interface IPlayable : IMedia
    {
        void Play();
        void Pause();
        void Stop();
    }
}
