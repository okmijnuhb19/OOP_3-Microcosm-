using OOP_3;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressSavingOption
{
    public class CompressingOption<T> : ISavingOption<T>
    {
        public List<T> Load(string path, ISerializer serializer)
        {
            List<T> instances = new List<T>();
            using (Stream s = File.OpenRead(path))
            using (Stream ds = new DeflateStream(s, CompressionMode.Decompress))
            using (Stream sd = new MemoryStream())
            {
                try
                {
                    ds.CopyTo(sd);
                    sd.Position = 0;
                    instances = serializer.Deserialize<List<T>>(sd).FirstOrDefault();
                }
                catch(Exception e)
                {
                    MessageBox.Show("You must delete old elements");
                }
                
            }

            return instances;
        }

        public void Save(string path, object obj, ISerializer serializer)
        {
            List<T> instences = this.Load(path, serializer);
            if (instences == null)
            {
                instences = new List<T>();
            }
            instences.Add((T)obj);

            using (Stream s = new FileStream(path, FileMode.Create))
            using (Stream ds = new DeflateStream(s, CompressionMode.Compress))
            {
                byte[] buff = serializer.Serialize(instences).ToArray();
                ds.Write(buff, 0, buff.Length);
            }
        }
    }
}
