﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloackLib
{
    public class MechanicalWatches : Cloack, IAlarmClock
    {
        //spring or weight lifted
        protected string energySource;
        //pendulum or balance wheel;
        protected string oscillatorySystem;

        public MechanicalWatches(string energySource, string oscillatorySystem)
        {
            this.energySource = energySource;
            this.oscillatorySystem = oscillatorySystem;
        }

        public virtual string Alarm()
        {
            return "Constant Sygnal";
        }
    }
}
