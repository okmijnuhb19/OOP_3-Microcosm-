using CommonForAdapting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.Adapter
{
    public class OptionAdapter<T> : OOP_3.ISavingOption<T>
    {
        public SaveOption<T> adaptee { get; set; }

        public List<T> Load(string path, ISerializer serializer)
        {
            var sa = new SerializeAdapter<T>(serializer);
            return adaptee.load(sa, path);

        }

        public void Save(string path, object obj, ISerializer serializer)
        {
            var sa = new SerializeAdapter<T>(serializer);
            var list = new List<T>();

            var defOp = new DefaultSavingOption<T>();
            var currentList = defOp.Load(path, serializer);
            if(currentList != null)
            {
                list.AddRange(currentList);
            }
            list.Add((T)obj);
            adaptee.save(sa, list, path);
        }
    }
}
