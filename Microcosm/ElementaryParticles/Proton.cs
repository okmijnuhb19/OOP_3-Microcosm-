using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public class Proton : Nucleon
    {
        public Proton()
        {
            mass = 1;
            electricCharge = 1;
            spin = 0.5;
        }

        public override void Access(IVisitor visitor)
        {
            visitor.VisitProton(this);
        }
    }
}
