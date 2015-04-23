using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloackLib
{
    public class CuckooClock : MechanicalWatches
    {
        protected string cuckoo;

        public CuckooClock(string cuckoo, string energySource, string oscillatorySystem)
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
