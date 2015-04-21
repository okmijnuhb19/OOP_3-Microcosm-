using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    public class MicrocosmFactory
    {
        private Dictionary<string, IMicrocosmCreator> factoryInstances;

        public MicrocosmFactory()
        {
            factoryInstances = new Dictionary<string, IMicrocosmCreator>();
        }

        public void Add<T>(string instanceName) where T : IMicrocosm, new()
        {
            if (factoryInstances.ContainsKey(instanceName))
                throw new Exception("this instance already exists");

            factoryInstances.Add(instanceName, new MicrocosmCreator<T>());
        }

        public List<IMicrocosm> Create()
        {
            List<IMicrocosm> elements = new List<IMicrocosm>();
            foreach (IMicrocosmCreator instance in factoryInstances.Values)
            {
                elements.Add(instance.Create());
            }

            return elements;
        }
    }
}
