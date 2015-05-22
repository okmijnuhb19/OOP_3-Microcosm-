using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    abstract class Nucleon : ElementaryParticle
    {
        private List<IMicrocosm> particles;

        public void Add(IMicrocosm particular)
        {
            particles.Add(particles);
        }

        public void Remove(IMicrocosm particular)
        {
            particles.Remove(particular);
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return particles.GetEnumerator();
        }
    }
}
