using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcosm.ElementaryParticles;
using System.Collections;

namespace Microcosm.Atoms
{
    [Serializable]
    public class Nucleus : IMicrocosm
    {
        public double Mass { get { return GetMass(); } }

        private List<IMicrocosm> particles;

        public Nucleus()
        {
            particles = new List<IMicrocosm>();
        }

        private double GetMass()
        {
            return particles.Select(x => x.Mass).Sum();
        }



        public void Add(IMicrocosm ep)
        {
            particles.Add(ep);
        }

        public void Remove(IMicrocosm ep)
        {
            particles.Remove(ep);
        }

        public IEnumerator GetEnumerator()
        {
            return particles.GetEnumerator();
        }
    }
}
