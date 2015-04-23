using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm.ElementaryParticles
{
    [Serializable]
    public class ElementaryParticle : FundamentalParticle
    {
        private List<IMicrocosm> particles;

        public override void Add(IMicrocosm particular)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public override void Remove(IMicrocosm particular)
        {
            throw new NotImplementedException("Elementary particle can't contain elements");
        }

        public override System.Collections.IEnumerator GetEnumerator()
        {
            yield return this;
        }
    }
}
