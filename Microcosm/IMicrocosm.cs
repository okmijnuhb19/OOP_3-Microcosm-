using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    interface IMicrocosm : IEnumerable
    {
        double Mass { get; }

        void Add(IMicrocosm ep);

        void Remove(IMicrocosm ep);

        IEnumerator GetEnumerator();
    }
}
