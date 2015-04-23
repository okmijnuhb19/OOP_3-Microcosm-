using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloackLib
{
    public abstract class Cloack
    {
        public virtual string Time()
        {
            return DateTime.Today.TimeOfDay.ToString();
        }
    }
}
