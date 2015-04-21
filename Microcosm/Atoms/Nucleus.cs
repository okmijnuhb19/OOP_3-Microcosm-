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



        public void Add(IMicrocosm particular)
        {
            particles.Add(particular);
        }

        public void Remove(IMicrocosm particular)
        {
            particles.Remove(particular);
        }

        public IEnumerator GetEnumerator()
        {
            return particles.GetEnumerator();
        }


        public void Access(IVisitor visitor)
        {
            visitor.VisitNucleus(this);
        }
    }
}
