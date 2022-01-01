using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreeColections;
using System.Drawing.Drawing2D;


namespace BinaryTree_TTCS
{
    public partial class frmBinaryTree : Form
    {
    
        public frmBinaryTree()
        {
            InitializeComponent();

        }

        private void btnGenerateTree_Click(object sender, EventArgs e)
        {
            bR_TreePanel1.GenerateTree((int)numSize.Value,
            (int)numMin.Value, (int)numMax.Value);
            //userControl_duyet1.GenerateTree((int)numSize.Value,
            //(int)numMin.Value, (int)numMax.Value);

        }

        private void btnInOrderTraverse_Click(object sender, EventArgs e)
        {
            bR_TreePanel1.InOrderTraverse();
            int j = 0;
            while (j < bR_TreePanel1._Count())
            {
                bR_TreePanel1.Refresh();
                bR_TreePanel1.SearchNode_LNR(j);

                j++;
            }
        }

        private void btnPreOrderTraverse_Click(object sender, EventArgs e)
        {
            bR_TreePanel1.PreOrderTraverse();
   
            int j = 0;
            while (j < bR_TreePanel1._Count())
            {
                bR_TreePanel1.Refresh();
                bR_TreePanel1.SearchNode_NLR(j);

                j++;
            }
        }
       
        private void btnPostOrderTraverse_Click(object sender, EventArgs e)
        {
            bR_TreePanel1.PostOrderTraverse();
            int j = 0;
            
            while (j < bR_TreePanel1._Count())
            {
                bR_TreePanel1.Refresh();
                bR_TreePanel1.SearchNode_LRN(j);

                j++;
            }
        }

     
    }
}
