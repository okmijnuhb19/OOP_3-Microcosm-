using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcosm.Atoms;

namespace OOP_BinarySerialization
{
    class AtomCreator<T> : IAtomCreator where T : Atom, new()
    {
        public Atom Create()
        {
            return new T();
        }
    }
}
