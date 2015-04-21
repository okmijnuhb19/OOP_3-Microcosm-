using Microcosm.Atoms;
using Microcosm.ElementaryParticles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    public class AtomCreator: IMicrocosmCreator
    {
        public IMicrocosm Create()
        {
            return new Atom();
        }
    }

    public class NucleusCreator : IMicrocosmCreator
    {
        public IMicrocosm Create()
        {
            return new Nucleus();
        }
    }

    public class ProtonCreator : IMicrocosmCreator
    {
        public IMicrocosm Create()
        {
            return new Proton();
        }
    }

    public class NeuronCreator : IMicrocosmCreator
    {
        public IMicrocosm Create()
        {
            return new Neutron();
        }
    }

    public class ElectronCreator : IMicrocosmCreator
    {
        public IMicrocosm Create()
        {
            return new Electron();
        }
    }

}
