using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisconnectedADO
{
    public partial class MDIParent1 : Form
    {
      

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void datasetFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void datasetFillWithParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_WithParameter f2 = new Frm_WithParameter();
            f2.Show();

        }

        
        
    }
}
