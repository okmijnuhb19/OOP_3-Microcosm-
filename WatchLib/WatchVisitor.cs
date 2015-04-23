using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchLib
{
    public abstract class WatchVisitor<T> where T: new()
    {
        public virtual T DynemicVisit(Watch w)
        {
            Visit((dynamic)w);
            return new T();
        }
        protected abstract void Visit(Watch w);

        protected virtual void Visit(SandGlass w) { Visit((Watch)w); }

        protected virtual void Visit(MechanicalWatches w) { Visit((Watch)w); }
        protected virtual void Visit(CuckooWatch w) { Visit((MechanicalWatches)w); }

        protected virtual void Visit(ElectronicWatch w) { Visit((Watch)w); }
        protected virtual void Visit(QuartzWatch w) { Visit((ElectronicWatch)w); }
    }
}
