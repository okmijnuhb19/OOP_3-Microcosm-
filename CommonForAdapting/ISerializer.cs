using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonForAdapting
{
    public interface ISerializer<T>
    {
        MemoryStream serialize(List<T> items);

        List<T> deserialize(string path);
    }
}
