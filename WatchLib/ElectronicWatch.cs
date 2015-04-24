using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    [Serializable]
    public class ElectronicWatch: Watch, IAlarmWatch
    {
        protected string electronicCircuit;

        public virtual string ElectricitySource { get; set; }
        public virtual string AlarmSignal { get; set; }

        public ElectronicWatch()
        {
            this.electronicCircuit = "";
            this.AlarmSignal = "";
            this.ElectricitySource = "";
        }

        public ElectronicWatch(string electronicCircuit, string electricitySource, string alarmSignal)
        {
            this.electronicCircuit = electronicCircuit;
            this.AlarmSignal = alarmSignal;
            this.ElectricitySource = electricitySource;
        }

        public string Alarm()
        {
            return AlarmSignal;
        }
    }
}
