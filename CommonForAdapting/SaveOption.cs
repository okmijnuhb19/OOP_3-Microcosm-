using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonForAdapting
{
    public abstract class SaveOption<T>
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void save(ISerializer<T> animalSerializer, List<T> animals, string path);

        public abstract List<T> load(ISerializer<T> animalSerializer, string path);
    }
}
