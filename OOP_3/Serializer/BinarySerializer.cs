using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public class BinarySerializer : ISerializer
    {
       private static BinarySerializer instance;

       private BinarySerializer() { }

       public static BinarySerializer Instance
       {
           get
           {
               if (instance == null)
               {
                   instance = new BinarySerializer();
               }

               return instance;
           }
       }

        public MemoryStream Serialize(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms;

        }

        public List<T> Deserialize<T>(Stream stream)
        {
            List<T> instances = new List<T>();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Binder = new Binder();

            while (stream.Position < stream.Length)
            {
                try
                {
                    instances.Add((T)bf.Deserialize(stream));
                }
                catch (Exception e)
                {
                    MessageBox.Show("object can't be loaded without required plugin");
                    return instances;
                }
            }

            return instances;
        }
    }



    public class Binder : SerializationBinder
    {

        public override Type BindToType(string assemblyName, string typeName)
        {
            Type tyType = null;
            string sShortAssemblyName = assemblyName.Split(',')[0];
            Assembly[] ayAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (Assembly ayAssembly in ayAssemblies)
            {
                if (sShortAssemblyName == ayAssembly.FullName.Split(',')[0])
                {
                    tyType = ayAssembly.GetType(typeName);
                    break;
                }
            }
            return tyType;
        }
    }
}
