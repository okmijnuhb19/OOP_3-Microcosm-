using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public class Neutron : Nucleon
    {
        public Neutron()
        {
            mass = 1;
            electricCharge = 0;
            spin = 0.5;
        }

        public override void Access(IVisitor visitor)
        {
            visitor.VisitNeutron(this);
        }
    }
}
