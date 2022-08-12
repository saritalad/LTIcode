using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConnectedADO
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void singleRecordSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void multipleRecordsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void bindingSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void insertCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaction t = new transaction();
            t.Show();
        }

        private void mARSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MARS mr = new MARS();
            mr.Show();
        }

        private void asynchronousReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AsynchronousOp a=new AsynchronousOp ();
           a.Show();

        }

        private void oLEDBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OLEDBForm ol = new OLEDBForm();
            ol.Show();
        }

        private void navigateExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateForm nf = new NavigateForm();
            nf.Show();

        }

        private void executeNonQryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteNonQury_Example ex = new ExecuteNonQury_Example();
            ex.Show();
        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void bulkCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bulkcopyForm b = new bulkcopyForm();
            b.Show();
        }

        private void bindingSourceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BindingSource_Ex bx = new BindingSource_Ex();
            bx.Show();
        }

        private void dataRelationExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRelation_Example dl=new DataRelation_Example ();
                dl.Show ();
        }

        private void bindingNavigatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
