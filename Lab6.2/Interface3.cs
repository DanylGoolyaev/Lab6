using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._2
{
    interface IRecordable : IMedia
    {
        void Record();
        void Pause();
        void Stop();
    }
    
}
