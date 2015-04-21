using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcosm.ElementaryParticles;

namespace Microcosm.Atoms
{
    [Serializable]
    public class Atom : IMicrocosm
    {
        public double Mass { get { return GetMass(); } }

        private List<Electron> electrons;
        private Nucleus nucleus;

        public Atom(int electrons, int protons, int neutrons)
        {
            InsertElectrons(electrons);
            CreateNucleus(protons, neutrons);
        }

        private void InsertElectrons(int count)
        {
            electrons = new List<Electron>();
            for (var i = 0; i < count; i++)
                electrons.Add(new Electron());
        }

        private void CreateNucleus(int protons, int neutrons)
        {
            nucleus = new Nucleus(protons, neutrons);
        }

        private double GetMass()
        {
            return nucleus.Mass;
        }
    }
}
