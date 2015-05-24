using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    [Export("MajorRevision")]
    public class DefaultSavingOption<T> : ISavingOption<T>
    {
        public List<T> Load(string path, ISerializer serializer)
        {
            List<T> instances = new List<T>();
            using (Stream stream = File.OpenRead(path))
            {
                instances = serializer.Deserialize<T>(stream);
            }

            return instances;
        }

        public void Save(string path, object obj, ISerializer serializer)
        {
            using (Stream stream = new FileStream(path, FileMode.Append))
            {
                byte[] buff = serializer.Serialize(obj).ToArray();
                stream.Write(buff, 0, buff.Length);
            }
        }
    }
}
