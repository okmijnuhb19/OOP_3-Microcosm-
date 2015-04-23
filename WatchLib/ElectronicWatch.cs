using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    public class ElectronicWatch: Watch, IAlarmWatch
    {
        protected string electronicCircuit;
        protected string electricitySource;
        protected string alarmSignal;

        public virtual string ElectricitySource { get; set; }
        public virtual string AlarmSignal { get; set; }

        public ElectronicWatch(string electronicCircuit, string electricitySource, string alarmSignal)
        {
            this.electronicCircuit = electronicCircuit;
            this.alarmSignal = alarmSignal;
            this.electricitySource = electricitySource;
        }

        public string Alarm()
        {
            return alarmSignal;
        }
    }
}
