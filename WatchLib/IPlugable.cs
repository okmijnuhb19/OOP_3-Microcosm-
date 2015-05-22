using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchLib
{
    public interface IPlugable
    {
        List<WatchField> GetFields();
        void SetFields(Dictionary<string, string> fields);
        string GetType();
    }
}
