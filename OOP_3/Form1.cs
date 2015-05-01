using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchLib;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        IFactory<Watch> watchFactory = new WatchFactory();
        IWatchCreator sandGlassCreator = new SandGlassCreator();
        IRepository<Watch> rep = new WatchRepository("db.bin");
        List<WatchControl> watchControls = new List<WatchControl>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawWatches(IEnumerable<Watch> watches)
        {
            int x = 10;
            int y = 10;
            int marginX = 0;

            WatchVisitor<WatchControl> visitor = new WidgetWatchVisitor();

            foreach (Watch w in watches)
            {
                WatchControl wc = visitor.DynemicVisit(w);
                wc.Parent = this;
                wc.AutoSize = true;
                wc.Location = new Point(x, 50);
                this.Controls.Add(wc);
                watchControls.Add(wc);

                x += wc.Width + marginX;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            DeleteWidgetsFormDisplay();
            watchControls.Clear();
            DrawWatches(rep.Load());
        }

        private void DeleteWidgetsFormDisplay()
        {
            foreach (var control in watchControls)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void DeleteNodeBtn_Click(object sender, EventArgs e)
        {
            rep.Clear();
            DeleteWidgetsFormDisplay();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Watch w = watchFactory.FactoryMethod(watchComboBox.Text);
            var wi = new WatchInitializingForm(w);

            wi.WatchInitializingEnded += onWatchInitializingEnded;
        }

        private void onWatchInitializingEnded(object sender, WatchInitEndedEventArgs e)
        {
            rep.Insert(e.watch);

            DeleteWidgetsFormDisplay();
            DrawWatches(rep.Load());
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            rep.Clear();
            IEnumerable<Watch> watches = watchControls.Select(x => x.Watch);
            foreach(Watch w in watches)
            {
                rep.Insert(w);
            }
        }
    }
}
