using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    public class SandGlass : Watch, IStopwatch
    {
        public double upperSand;
        public double bottomSand;
        public double sand;
        public double totalTime;
 
        public SandGlass(double sand, double totalTime)
        {
            this.sand = sand;
            this.totalTime = totalTime;
        }

        public override string Time()
        {
            int time = (int)((bottomSand / sand) * totalTime);
            return time.ToString();
        }

        public void Reverse()
        {
            double t = upperSand;
            upperSand = bottomSand;
            bottomSand = t;
        }

        public void Start()
        {
            Reverse();
        }

        public void Reset()
        {
            upperSand = 0;
            bottomSand = sand;
        }
    }
}
