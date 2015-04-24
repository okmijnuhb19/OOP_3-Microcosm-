using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class WatchRepository : IRepository<WatchLib.Watch>
    {
        string dbName;

        public WatchRepository(string dbName)
        {
            this.dbName = dbName;
        }

        public void Insert(WatchLib.Watch entity)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (!File.Exists(dbName))
            {
                using (File.Create(dbName)) { }
            }

            using (Stream stream = new FileStream(dbName, FileMode.Append))
            {
                bf.Serialize(stream, entity);
            }
        }

        public void Delete(WatchLib.Watch entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WatchLib.Watch> Load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<WatchLib.Watch> watches = new List<WatchLib.Watch>();

            if(!File.Exists(dbName))
            {
                return watches;
            }

            using (Stream stream = File.OpenRead(dbName))
            {
                while(stream.Position < stream.Length)
                    watches.Add((WatchLib.Watch)bf.Deserialize(stream));
            }

            return watches.Select(x => x);
        }

        public void Clear()
        {
            if (File.Exists(dbName))
            {
                File.Delete(dbName);
            }
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
