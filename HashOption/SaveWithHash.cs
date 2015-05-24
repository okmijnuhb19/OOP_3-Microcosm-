using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Composition;
using CommonForAdapting;

namespace HashCounter
{
    [Export(typeof(SaveOption<>))]
    [ExportMetadata("Name", "Сохранение/загрузка с хешем")]
    public class SaveWithHash<T> : SaveOption<T>
    {
        public SaveWithHash()
        {
            name = "hash";
        }

        private HashCounter hashCounter = new HashCounter();

        public override void save(ISerializer<T> serializer, List<T> items, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            MemoryStream data = serializer.serialize(items);
            data.WriteTo(fs);
            fs.Close();
            File.WriteAllText("hash.txt", hashCounter.createHash(data.ToArray()));
        }

        public override List<T> load(ISerializer<T> serializer, string path)
        {
            byte[] data = File.ReadAllBytes(path);
            string hash = "";
            try
            {
                hash = File.ReadAllText("hash.txt");
            }
            catch (FileNotFoundException) { }
            if (hashCounter.compareHash(data, hash))
                return serializer.deserialize(path);
            else
                System.Windows.Forms.MessageBox.Show("Не удалось найти хэш");
                return null;
        }
    }
}
