
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WatchLib;

namespace OOP_3
{
    public class WatchFactory : IFactory<Watch>
    {
        public WatchFactory() { }

        public Watch FactoryMethod(string type)
        {
            string[] types = PluginManager.Instance.GetAssignableTypesNames(typeof(Watch));
            if(!types.Contains(type))
            {
                throw new Exception("WatchFactory: invalid type");
            }

            return (Watch)PluginManager.Instance.CreateInstance(type);
        }


        public string[] GetTypes()
        {
            return PluginManager.Instance.GetAssignableTypesNames(typeof(Watch));
        }
    }
}
