using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public interface ISavingOption<T>
    {
        List<T> Load(string path, ISerializer serializer);

        void Save(string path, object obj, ISerializer serializer);
    }
}
