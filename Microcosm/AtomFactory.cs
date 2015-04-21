using Microcosm.Atoms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BinarySerialization
{
    class AtomFactory
    {
        private Dictionary<string, IAtomCreator> factoryInstances;

        public AtomFactory()
        {
            factoryInstances = new Dictionary<string, IAtomCreator>();
        }

        public void Add<T>(string instanceName) where T : Atom, new()
        {
            if (factoryInstances.ContainsKey(instanceName))
                throw new Exception("this instance already exists");

            factoryInstances.Add(instanceName, new AtomCreator<T>());
        }

        public List<Atom> Create()
        {
            List<Atom> atoms = new List<Atom>();
            foreach(IAtomCreator instance in factoryInstances.Values)
            {
                atoms.Add(instance.Create());
            }

            return atoms;
        }
    }
}
