using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchLib
{
    public class WatchCreatingWidgetVisitor : WatchVisitor<WatchCreatingControl>
    {
        private int elementY;
        private int elementMarginY = 10;
        private int elementMarginX = 10;
        private int elementStartPosY = 60;
        private string watchType;

        WatchCreatingControl watchControl;

        public override WatchCreatingControl DynemicVisit(Watch w)
        {
            watchControl = new WatchCreatingControl(w);
            elementY = elementStartPosY;
            base.DynemicVisit(w);
            watchControl.WatchType = watchType;
            watchControl.Height = elementMarginY;

            return watchControl;
        }

        protected override void Visit(Watch w) { }

        protected override void Visit(SandGlass w)
        {
            base.Visit(w);
            watchType = "SandGlass";

            WatchField wf = new WatchField("Sand", "");
            AddWatchField(wf);
            wf = new WatchField("TotalTime", "");
            AddWatchField(wf);
        }

        protected override void Visit(MechanicalWatches w)
        {
            base.Visit(w);
            watchType = "MechanicalWatches";

            WatchField wf = new WatchField("EnetgySource", "");
            AddWatchField(wf);
            wf = new WatchField("OscillatorySystem", "");
            AddWatchField(wf);

        }
        protected override void Visit(CuckooWatch w)
        {
            base.Visit(w);
            watchType = "CuckooWatch";

            WatchField wf = new WatchField("Cuckoo", "");
            AddWatchField(wf);
        }

        protected override void Visit(ElectronicWatch w)
        {
            base.Visit(w);
            watchType = "ElectronicWatch";

            WatchField wf = new WatchField("ElectricitySource", "");
            AddWatchField(wf);
            wf = new WatchField("AlarmSignal", "");
            AddWatchField(wf);
        }
        protected override void Visit(QuartzWatch w)
        {
            base.Visit(w);
            watchType = "QuartzWatch";

            WatchField wf = new WatchField("QuartzCrystal", "");
            AddWatchField(wf);
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
