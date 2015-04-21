using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public class Electron : ElementaryParticle
    {
        public Electron()
        {
            mass = 5.48E-4;
            e = -1.6;
            spin = 0.5;
        }

        public override void Access(IVisitor visitor)
        {
            visitor.VisitElectron(this);
        }
    }
}
