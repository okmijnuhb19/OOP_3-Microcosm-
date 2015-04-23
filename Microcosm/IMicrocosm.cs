using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    public interface IMicrocosm : IEnumerable
    {
        double Mass { get; }

        double e { get; }

        void Add(IMicrocosm particular);

        void Remove(IMicrocosm particular);

        void Access(IVisitor visitor);
    }
}
