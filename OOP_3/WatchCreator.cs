using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchLib;

namespace OOP_3
{
    public class MechaniclaWatchCreator : IWatchCreator
    {
        public Watch Create()
        {
            return new MechanicalWatches();
        }
    }

    public class CuckooWatchCreator : IWatchCreator
    {
        public Watch Create()
        {
            return new CuckooWatch();
        }
    }



    public class ElectronicWatchCreator : IWatchCreator
    {
        public Watch Create()
        {
            return new ElectronicWatch();
        }
    }

    public class QuartzWatchCreator : IWatchCreator
    {
        public Watch Create()
        {
            return new QuartzWatch();
        }
    }



    public class SandGlassCreator : IWatchCreator
    {
        public Watch Create()
        {
            return new SandGlass();
        }
    }

}
