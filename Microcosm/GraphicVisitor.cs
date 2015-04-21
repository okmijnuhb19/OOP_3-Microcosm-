using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcosm
{
    public class GraphicVisitor: IVisitor
    {
        private MicrocosmNode treeNode;

        public GraphicVisitor(MicrocosmNode treeNode)
        {
            this.treeNode = treeNode;
        }

        public void VisitAtom(Atoms.Atom atom)
        {
            treeNode.MicrocosElement = atom;
            treeNode.Text = "Atom";

            MicrocosmNode atomNode = treeNode;
            foreach (IMicrocosm m in atom)
            {
                treeNode = new MicrocosmNode();
                treeNode.MicrocosParent = atom;
                m.Access(this);
                atomNode.Nodes.Add(treeNode);
            }
            treeNode = atomNode;
        }

        public void VisitNucleus(Atoms.Nucleus nucleus)
        {
            treeNode.MicrocosElement = nucleus;
            treeNode.Text = "Nucleus";

            MicrocosmNode nucleusNode = treeNode;
            foreach (IMicrocosm m in nucleus)
            {
                treeNode = new MicrocosmNode();
                treeNode.MicrocosParent = nucleus;
                m.Access(this);
                nucleusNode.Nodes.Add(treeNode);
            }
            treeNode = nucleusNode;
        }

        public void VisitNeutron(ElementaryParticles.Neutron neutron)
        {
            treeNode.MicrocosElement = neutron;
            treeNode.Text = "neutron";
        }

        public void VisitProton(ElementaryParticles.Proton proton)
        {
            treeNode.MicrocosElement = proton;
            treeNode.Text = "proton";
        }

        public void VisitElectron(ElementaryParticles.Electron electron)
        {
            treeNode.MicrocosElement = electron;
            treeNode.Text = "electron";
        }
    }
}
