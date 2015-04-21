﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    class Neutron : ElementaryParticle
    {
        public Neutron()
        {
            mass = 1;
            e = 0;
            spin = 0.5;
        }
    }
}
