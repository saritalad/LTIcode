namespace DataReader_Examples
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereClauseExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datBindingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asynchronousQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataReaderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataReaderToolStripMenuItem
            // 
            this.dataReaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataGridViewExampleToolStripMenuItem,
            this.whereClauseExampleToolStripMenuItem,
            this.insertQueryToolStripMenuItem,
            this.datBindingToolStripMenuItem,
            this.asynchronousQueryToolStripMenuItem});
            this.dataReaderToolStripMenuItem.Name = "dataReaderToolStripMenuItem";
            this.dataReaderToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.dataReaderToolStripMenuItem.Text = "DataReader";
            // 
            // dataGridViewExampleToolStripMenuItem
            // 
            this.dataGridViewExampleToolStripMenuItem.Name = "dataGridViewExampleToolStripMenuItem";
            this.dataGridViewExampleToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.dataGridViewExampleToolStripMenuItem.Text = "DataGridView Example";
            this.dataGridViewExampleToolStripMenuItem.Click += new System.EventHandler(this.dataGridViewExampleToolStripMenuItem_Click);
            // 
            // whereClauseExampleToolStripMenuItem
            // 
            this.whereClauseExampleToolStripMenuItem.Name = "whereClauseExampleToolStripMenuItem";
            this.whereClauseExampleToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.whereClauseExampleToolStripMenuItem.Text = "Where Clause _Example";
            this.whereClauseExampleToolStripMenuItem.Click += new System.EventHandler(this.whereClauseExampleToolStripMenuItem_Click);
            // 
            // insertQueryToolStripMenuItem
            // 
            this.insertQueryToolStripMenuItem.Name = "insertQueryToolStripMenuItem";
            this.insertQueryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.insertQueryToolStripMenuItem.Text = "Insert Query";
            this.insertQueryToolStripMenuItem.Click += new System.EventHandler(this.insertQueryToolStripMenuItem_Click);
            // 
            // datBindingToolStripMenuItem
            // 
            this.datBindingToolStripMenuItem.Name = "datBindingToolStripMenuItem";
            this.datBindingToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.datBindingToolStripMenuItem.Text = "Update Query Delete Query";
            this.datBindingToolStripMenuItem.Click += new System.EventHandler(this.datBindingToolStripMenuItem_Click);
            // 
            // asynchronousQueryToolStripMenuItem
            // 
            this.asynchronousQueryToolStripMenuItem.Name = "asynchronousQueryToolStripMenuItem";
            this.asynchronousQueryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.asynchronousQueryToolStripMenuItem.Text = "Asynchronous Query";
            this.asynchronousQueryToolStripMenuItem.Click += new System.EventHandler(this.asynchronousQueryToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "DataReader Examples";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGridViewExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereClauseExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datBindingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asynchronousQueryToolStripMenuItem;
    }
}



