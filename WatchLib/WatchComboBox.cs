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
        public void SetClasses(string[] types)
        {
            this.Items.Clear();

            foreach(var type in types)
            {
                this.Items.Add(type);
            }
        }
    }
}
