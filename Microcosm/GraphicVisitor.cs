using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcosm
{
    class GraphicVisitor: IVisitor
    {
        private Graphics g;

        public GraphicVisitor(Graphics g)
        {
            this.g = g;
        }

        public void VisitAtom(Atoms.Atom atom)
        {
            throw new NotImplementedException();
        }

        public void VisitNucleus(Atoms.Nucleus nucleus)
        {
            throw new NotImplementedException();
        }

        public void VisitNeutron(ElementaryParticles.Neutron neutron)
        {
            throw new NotImplementedException();
        }

        public void VisitProton(ElementaryParticles.Proton proton)
        {
            throw new NotImplementedException();
        }

        public void VisitElectron(ElementaryParticles.Electron electron)
        {
            //Pen p = new Pen(Color.Blue);o
            //g.DrawEllipse(p, )
        }
    }
}
