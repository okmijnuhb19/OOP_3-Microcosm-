using Microcosm.Atoms;
using Microcosm.ElementaryParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    public interface IVisitor
    {
        void VisitAtom(Atom atom);
        void VisitNucleus(Nucleus nucleus);
        void VisitNeutron(Neutron neutron);
        void VisitProton(Proton proton);
        void VisitElectron(Electron electron);
    }
}
