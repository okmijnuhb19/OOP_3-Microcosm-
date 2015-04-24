using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WatchLib
{
    [Serializable]
    public abstract class Watch
    {
        public virtual string Time()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
