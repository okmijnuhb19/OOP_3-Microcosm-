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
using WatchLib;

namespace OOP_3
{
    class WatchRepository : IRepository<Watch>
    {
        string dbName;
        
        public ISavingOption<Watch> SavingOption { get; set; }

        public WatchRepository(string dbName)
        {
            this.dbName = dbName;
            this.SavingOption = new DefaultSavingOption<Watch>();
        }

        public void Insert(Watch entity)
        {
            if (!File.Exists(dbName))
            {
                using (File.Create(dbName)) { }
            }

            SavingOption.Save(dbName, entity, BinarySerializer.Instance);
        }

        public void Delete(Watch entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Watch> Load()
        {
            if(!File.Exists(dbName))
            {
                return new List<Watch>();
            }

            return SavingOption.Load(dbName, BinarySerializer.Instance);
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
