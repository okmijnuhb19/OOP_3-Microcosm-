using Microcosm;
using Microcosm.Atoms;
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

namespace OOP_3
{
    public partial class Form1 : Form
    {

        IMicrocosmCreator electronCreator = new ElectronCreator();
        IMicrocosmCreator protonCreator = new ProtonCreator();
        IMicrocosmCreator neutronCreator = new NeuronCreator();
        IMicrocosmCreator nucleusCreator = new NucleusCreator();
        IMicrocosmCreator atomCreator = new AtomCreator();

        MicrocosmNode curNode;
        List<IMicrocosm> mcList;

        public Form1()
        {
            InitializeComponent();

            BinaryFormatter bf = new BinaryFormatter();
            mcList = new List<IMicrocosm>();

            IMicrocosm atom = atomCreator.Create();
            IMicrocosm nucleus = nucleusCreator.Create();
            nucleus.Add(protonCreator.Create());
            nucleus.Add(neutronCreator.Create());

            atom.Add(nucleus);
            atom.Add(electronCreator.Create());
            atom.Add(electronCreator.Create());
            atom.Add(electronCreator.Create());

            IMicrocosm newAtom = atomCreator.Create();
            newAtom.Add(electronCreator.Create());
            newAtom.Add(electronCreator.Create());

            mcList.Add(newAtom);
            mcList.Add(atom);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawList();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            curNode = e.Node as MicrocosmNode;
        }

        private void DrawList()
        {
            treeView.Nodes.Clear();
            foreach (IMicrocosm m in mcList)
            {
                MicrocosmNode tn = new MicrocosmNode();
                IVisitor v = new GraphicVisitor(tn);
                m.Access(v);

                treeView.Nodes.Add(tn);
            }

            treeView.ExpandAll();
        }

        private void DeleteNodeBtn_Click(object sender, EventArgs e)
        {
            IMicrocosm element = curNode.MicrocosElement;
            IMicrocosm parent = curNode.MicrocosParent;

            if (parent != null)
            {
                parent.Remove(element);
            }
            else
            {
                mcList.Remove(element);
            }

            DrawList();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream s = File.OpenRead("Microcosm.bin"))
            {
                mcList = (List<IMicrocosm>)bf.Deserialize(s);
            }

            DrawList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream s = File.Create("Microcosm.bin"))
            {
                bf.Serialize(s, mcList);
            }
        }
    }
}
