using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microcosm
{
    public class FundamentalParticle : IMicrocosm
    {
        protected double mass;
        protected double electricCharge;
        protected double spin;

        public double Mass { get { return mass; } }
        public double e { get { return electricCharge; } }
        public double Spin { get { return spin; } }


        public virtual void Add(IMicrocosm particular)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public virtual void Remove(IMicrocosm particular)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public virtual System.Collections.IEnumerator GetEnumerator()
        {
            yield return this;
        }


        public virtual void Access(IVisitor visitor) { }
    }
}
