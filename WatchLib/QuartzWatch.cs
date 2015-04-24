using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    [Serializable]
    public class QuartzWatch : ElectronicWatch, IAnalogWatch
    {
        public string QuartzCrystal { get; set; }

        public QuartzWatch()
            :base()
        {
            QuartzCrystal = "";
        }

        public QuartzWatch(string quartzCrystal, string electricitySource, string electronicCircuit, string alarmSygnal)
            : base(electronicCircuit, electricitySource, alarmSygnal)
        {
            this.QuartzCrystal = quartzCrystal;
        }

        public void AnalogDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
