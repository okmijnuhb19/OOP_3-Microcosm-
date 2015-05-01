using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchLib
{
    public class WatchInitVisitor : WatchVisitor<Watch>
    {
        Dictionary<string, string> fields;

        public WatchInitVisitor(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public void SetFields(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public override Watch DynemicVisit(Watch w)
        {
            base.DynemicVisit(w);

            return w;
        }

        protected override void Visit(Watch w) { }

        protected override void Visit(SandGlass w)
        {
            base.Visit(w);
            w.sand = Double.Parse(fields["Sand"]);
            w.totalTime = Double.Parse(fields["TotalTime"]);
        }

        protected override void Visit(MechanicalWatches w)
        {
            base.Visit(w);
            w.EnergySource = fields["EnetgySource"];
            w.OscillatorySystem = fields["OscillatorySystem"];

        }
        protected override void Visit(CuckooWatch w)
        {
            base.Visit(w);
            w.Cuckoo = fields["Cuckoo"];
        }

        protected override void Visit(ElectronicWatch w)
        {
            base.Visit(w);
            w.ElectricitySource = fields["ElectricitySource"];
            w.AlarmSignal = fields["AlarmSignal"];
        }
        protected override void Visit(QuartzWatch w)
        {
            base.Visit(w);
            w.QuartzCrystal = fields["QuartzCrystal"];
        }
    }
}
