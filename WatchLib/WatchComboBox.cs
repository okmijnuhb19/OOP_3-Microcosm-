using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchLib
{
    public class WatchComboBox : ComboBox
    {
        public WatchComboBox()
        {
            /*foreach(var item in WatchClasses())
            {
                this.Items.Add(item);
            }*/
        }

        private IEnumerable<string> WatchClasses()
        {
            yield return "Electronic";
            yield return "Quartz";
            yield return "Mechanical";
            yield return "CucooWatch";
            yield return "SandGlass";
        }
    }
}
