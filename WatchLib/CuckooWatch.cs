﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WatchLib
{
    [Serializable]
    public class CuckooWatch : MechanicalWatches
    {
        protected string cuckoo;

        public string Cuckoo { get { return cuckoo; } set { cuckoo = value; } }

        public CuckooWatch() 
            : base()
        {
            cuckoo = "";
        }

        public CuckooWatch(string cuckoo, string energySource, string oscillatorySystem)
            : base(energySource, oscillatorySystem)
        {
            this.cuckoo = cuckoo;
        }

        public override string Alarm()
        {
            return cuckoo;
        }
    }
}
