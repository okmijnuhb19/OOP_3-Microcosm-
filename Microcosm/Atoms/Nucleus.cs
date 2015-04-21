using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcosm.ElementaryParticles;

namespace Microcosm.Atoms
{
    [Serializable]
    public class Nucleus : IMicrocosm
    {
        private List<Proton> protons;
        private List<Neutron> neutrons;

        public double Mass { get { return GetMass(); } }

        public Nucleus(int protons, int neutrons)
        {
            InsertProtons(protons);
            InsertNeutrons(neutrons);
        }

        private void InsertProtons(int count)
        {
            protons = new List<Proton>();
            for (var i = 0; i < count; i++)
                protons.Add(new Proton());
        }

        private void InsertNeutrons(int count)
        {
            neutrons = new List<Neutron>();
            for (var i = 0; i < count; i++)
                neutrons.Add(new Neutron());
        }

        private double GetMass()
        {
            return protons.Select((Proton x) => x.Mass).Sum()
                + neutrons.Select((Neutron x) => x.Mass).Sum();
        }
    }
}
