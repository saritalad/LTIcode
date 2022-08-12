using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataReader_Examples
{
    public partial class MDIParent1 : Form
    {
       
        public MDIParent1()
        {
            InitializeComponent();
        }

       

       

      

       
        private void dataGridViewExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void whereClauseExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search f2 = new Search();
            f2.Show();
        }

        private void insertQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void datBindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void asynchronousQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ASynchronous A = new ASynchronous();
            A.Show();
        }
    }
}
