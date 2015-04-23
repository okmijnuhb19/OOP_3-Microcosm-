using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    public class QuartzClock : ElectronicWatch, IAnalogWatch
    {
        protected string quartzCrystal;

        public QuartzClock(string quartzCrystal, string electricitySource, string electronicCircuit, string alarmSygnal)
            : base(electronicCircuit, electricitySource, alarmSygnal)
        {
            this.quartzCrystal = quartzCrystal;
        }

        public void AnalogDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
