using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_3
{
    interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IEnumerable<T> Load();
        void Clear();
        void SaveChanges();
    }
}
