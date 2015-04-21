using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public class Proton : ElementaryParticle
    {
        public Proton()
        {
            mass = 1;
            e = 1;
            spin = 0.5;
        }
    }
}
