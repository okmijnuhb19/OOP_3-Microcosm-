using Microcosm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microcosm
{
    public class MicrocosmNode: TreeNode
    {
        IMicrocosm parent;
        IMicrocosm element;

        public IMicrocosm MicrocosElement { get { return element; } set { element = value; } }
        public IMicrocosm MicrocosParent { get { return parent; } set { parent = value; } }

        public MicrocosmNode()
            : base() { }

        public MicrocosmNode(IMicrocosm element)
            : this()
        {
            this.element = element;
        }

        public MicrocosmNode(IMicrocosm element, IMicrocosm parent) 
            : this(element)
        {
            this.parent = parent;
        }
    }
}
