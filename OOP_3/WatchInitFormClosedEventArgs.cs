using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchLib;

namespace OOP_3
{
    public class WatchInitEndedEventArgs : EventArgs
    {
        public Watch watch { get; set; }

        public WatchInitEndedEventArgs(Watch watch)
        {
            this.watch = watch;
        }
    }
}
