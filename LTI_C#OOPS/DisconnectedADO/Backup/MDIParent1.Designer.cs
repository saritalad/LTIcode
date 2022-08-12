namespace DisconnectedADO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataSetExamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetFillWithParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSetExamplesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataSetExamplesToolStripMenuItem
            // 
            this.dataSetExamplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datasetFillToolStripMenuItem,
            this.datasetFillWithParameterToolStripMenuItem});
            this.dataSetExamplesToolStripMenuItem.Name = "dataSetExamplesToolStripMenuItem";
            this.dataSetExamplesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.dataSetExamplesToolStripMenuItem.Text = "DataSet Examples";
            // 
            // datasetFillToolStripMenuItem
            // 
            this.datasetFillToolStripMenuItem.Name = "datasetFillToolStripMenuItem";
            this.datasetFillToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.datasetFillToolStripMenuItem.Text = "Dataset Fill";
            this.datasetFillToolStripMenuItem.Click += new System.EventHandler(this.datasetFillToolStripMenuItem_Click);
            // 
            // datasetFillWithParameterToolStripMenuItem
            // 
            this.datasetFillWithParameterToolStripMenuItem.Name = "datasetFillWithParameterToolStripMenuItem";
            this.datasetFillWithParameterToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.datasetFillWithParameterToolStripMenuItem.Text = "Dataset Fill with Parameter";
            this.datasetFillWithParameterToolStripMenuItem.Click += new System.EventHandler(this.datasetFillWithParameterToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataSetExamplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasetFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datasetFillWithParameterToolStripMenuItem;

    }
}



