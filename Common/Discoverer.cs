using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Discoverer
    {
        public string[] GetPluginTypeNames(string assemblyPath)
        {
            List<string> typeNames = new List<string>();
            Assembly a = Assembly.LoadFrom(assemblyPath);
            foreach (Type t in a.GetTypes())
            {
                if (t.IsPublic && typeof(IWatchPlugin).IsAssignableFrom(t))
                {
                    typeNames.Add(t.FullName);
                }
            }

            return typeNames.ToArray();
        }
    }
}
