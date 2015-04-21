using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    public class MicrocosmCreator<T> : IMicrocosmCreator where T : IMicrocosm, new()
    {
        public IMicrocosm Create()
        {
            return new T();
        }
    }
}
