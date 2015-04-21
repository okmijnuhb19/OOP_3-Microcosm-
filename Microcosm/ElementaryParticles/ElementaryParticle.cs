using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public abstract class ElementaryParticle : IMicrocosm
    {
        protected double mass;
        protected double e;
        protected double spin;

        public double Mass { get { return mass; } }
        public double E { get { return e; } }
        public double Spin { get { return spin; } }


        public void Add(IMicrocosm ep)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public void Remove(IMicrocosm ep)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}
