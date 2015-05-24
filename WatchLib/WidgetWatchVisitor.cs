using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchLib
{
    public class WidgetWatchVisitor : WatchVisitor<WatchControl>
    {
        private int elementY;
        private int elementMarginY = 10;
        private int elementMarginX = 10;
        private int elementStartPosY = 25;
        private string watchType;

        WatchControl watchControl;

        public override WatchControl DynemicVisit(Watch w)
        {
            watchControl = new WatchControl(w);
            elementY = elementStartPosY;
            base.DynemicVisit(w);
            watchControl.WatchType = watchType;
            watchControl.Height = elementMarginY;

            return watchControl;
        }

        protected override void Visit(Watch w)
        {
            WatchField wf = new WatchField("Time", w.Time());
            AddWatchField(wf);
        }

        protected override void Visit(SandGlass w)
        {
            base.Visit(w);
            watchType = "SandGlass";

            WatchField wf = new WatchField("Sand", w.sand.ToString());
            AddWatchField(wf);
            wf = new WatchField("TotalTime", w.totalTime.ToString());
            AddWatchField(wf);
        }

        protected override void Visit(MechanicalWatches w)
        {
            base.Visit(w);
            watchType = "MechanicalWatches";

            WatchField wf = new WatchField("EnergySource", w.EnergySource);
            AddWatchField(wf);
            wf = new WatchField("OscillatorySystem", w.OscillatorySystem);
            AddWatchField(wf);

        }
        protected override void Visit(CuckooWatch w)
        {
            base.Visit(w);
            watchType = "CuckooWatch";

            WatchField wf = new WatchField("Cuckoo", w.Cuckoo);
            AddWatchField(wf);
        }

        protected override void Visit(ElectronicWatch w)
        {
            base.Visit(w);
            watchType = "ElectronicWatch";
                       
            WatchField wf = new WatchField("ElectricitySource", w.ElectricitySource);
            AddWatchField(wf);
            wf = new WatchField("AlarmSignal", w.AlarmSignal);
            AddWatchField(wf);
        }
        protected override void Visit(QuartzWatch w) 
        {
            base.Visit(w);
            watchType = "QuartzWatch";
            
            WatchField wf = new WatchField("QuartzCrystal", w.QuartzCrystal);
            AddWatchField(wf);
        }

        protected override void Visit(IPlugable w) 
        {
            foreach(var f in w.GetFields())
            {
                AddWatchField(f);
            }
        }

        private void AddWatchField(WatchField wf)
        {
            wf.Top = elementY;
            wf.Left = elementMarginX;
            watchControl.Add(wf);

            elementY += (wf.Height + elementMarginY);
        }
    }
}
