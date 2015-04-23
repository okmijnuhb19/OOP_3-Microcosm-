using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloackLib
{
    public class SandGlass : Cloack, IStopwatch
    {
        private double upperSand;
        private double bottomSand;
        private double sand;
        private double totalTime;
 
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
