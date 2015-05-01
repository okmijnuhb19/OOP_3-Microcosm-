using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    [Serializable]
    public class ElectronicWatch: Watch, IAlarmWatch
    {
        public virtual string ElectricitySource { get; set; }
        public virtual string AlarmSignal { get; set; }

        public ElectronicWatch()
        {
            this.AlarmSignal = "";
            this.ElectricitySource = "";
        }

        public ElectronicWatch(string electricitySource, string alarmSignal)
        {
            this.AlarmSignal = alarmSignal;
            this.ElectricitySource = electricitySource;
        }

        public string Alarm()
        {
            return AlarmSignal;
        }
    }
}
