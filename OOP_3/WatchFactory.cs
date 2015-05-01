using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchLib;

namespace OOP_3
{
    public class WatchFactory : IFactory<Watch>
    {
        Discoverer d;

        public WatchFactory()
        {
            this.d = new Discoverer();
        }

        public Watch FactoryMethod(string type)
        {
            switch(type)
            {
                case "Electronic":
                    return new ElectronicWatch();
                case "Quartz":
                    return new QuartzWatch();
                case "Mechanical":
                    return new MechanicalWatches();
                case "CucooWatch":
                    return new CuckooWatch();
                case "SandGlass":
                    return new SandGlass();
                default:
                    throw new Exception("WatchFactory: invalid type");
            }
        }
    }
}
