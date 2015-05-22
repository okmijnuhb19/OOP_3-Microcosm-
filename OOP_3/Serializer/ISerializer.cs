using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public interface ISerializer
    {
        MemoryStream Serialize(object obj);

        List<T> Deserialize<T>(Stream stream);
    }
}
