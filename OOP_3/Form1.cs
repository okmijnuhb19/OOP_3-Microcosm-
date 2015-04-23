using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchLib;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BinaryFormatter bf = new BinaryFormatter();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawWatch();
        }

        private void DrawWatch()
        {
            Watch w = new SandGlass(100, 1000);
            WatchVisitor<WatchControl> visitor = new WidgetWatchVisitor();
            WatchControl wc = visitor.DynemicVisit(w);
            wc.Parent = this;
            wc.AutoSize = true;
            wc.Location = new Point(50, 50);
            this.Controls.Add(wc);

            w = new QuartzWatch("simple quartz", "battery", "arduino", "tzzzz");
            wc = visitor.DynemicVisit(w);
            wc.Parent = this;
            wc.AutoSize = true;
            wc.Location = new Point(50 + wc.Width, 50);
            this.Controls.Add(wc);
        }

    }
}
