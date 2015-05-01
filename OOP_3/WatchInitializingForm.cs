using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchLib;

namespace OOP_3
{
    public class WatchInitializingForm : Form
    {
        private Watch watch;
        private WatchCreatingControl wcc;

        public event EventHandler<WatchInitEndedEventArgs> WatchInitializingEnded;

        public WatchInitializingForm(Watch watch)
            : base()
        {
            this.watch = watch;
            this.AutoSize = true;
            DisplayWidget();
            this.Show();
        }

        void DisplayWidget()
        {
            var wcw = new WatchCreatingWidgetVisitor();
            wcc = wcw.DynemicVisit(watch);
            wcc.AutoSize = true;

            this.Controls.Add(wcc);

            wcc.CreateBtn.Click += InitializeFields;
        }

        void InitializeFields(object sender, EventArgs e)
        {
            var wiv = new WatchInitVisitor(wcc.GetWatchFieldsAsDictionary());
            wiv.DynemicVisit(watch);
            WatchInitializingEnded(this, new WatchInitEndedEventArgs(watch));

            this.Close();
        }

    }
}
