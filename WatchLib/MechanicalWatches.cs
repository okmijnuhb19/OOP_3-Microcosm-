using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    public class MechanicalWatches : Watch, IAlarmWatch, IAnalogWatch
    {
        //spring or weight lifted
        protected string energySource;
        //pendulum or balance wheel;
        protected string oscillatorySystem;

        public string EnergySource { get { return energySource; } set { energySource = value; } }
        public string OscillatorySystem { get { return oscillatorySystem; } set { oscillatorySystem = value; } }

        public MechanicalWatches(string energySource, string oscillatorySystem)
        {
            this.energySource = energySource;
            this.oscillatorySystem = oscillatorySystem;
        }

        public virtual string Alarm()
        {
            return "Constant Sygnal";
        }

        public void AnalogDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
