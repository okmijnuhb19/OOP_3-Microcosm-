using CommonForAdapting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Adapter
{
    public class SerializeAdapter<T> : ISerializer<T>
    {
        OOP_3.ISerializer adaptee;

        public SerializeAdapter(OOP_3.ISerializer s)
        {
            adaptee = s;
        }

        public System.IO.MemoryStream serialize(List<T> items)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buff;
            foreach (var item in items)
            {
                buff = adaptee.Serialize(item).ToArray();
                ms.Write(buff, 0, buff.Length);
            }

            return ms;
        }

        public List<T> deserialize(string path)
        {
            List<T> instances = new List<T>();
            using(Stream s = File.OpenRead(path))
            {
                instances = adaptee.Deserialize<T>(s);
            }

            return instances;
        }
    }
}
