using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchLib;

namespace OOP_3
{
    public interface IFactory<T>
    {
        T FactoryMethod(string type); 
    }
}
