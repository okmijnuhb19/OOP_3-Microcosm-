using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloackLib
{
    public class QuartzClock : ElectronicWatch
    {
        protected string quartzCrystal;

        public QuartzClock(string quartzCrystal, string electricitySource, string electronicCircuit, string alarmSygnal)
            : base(electronicCircuit, electricitySource, alarmSygnal)
        {
            this.quartzCrystal = quartzCrystal;
        }

        public override string Time()
        {
            return "cloack face: " + base.Time();
        }
    }
}
