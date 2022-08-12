namespace ConnectedADO
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
            this.dataReaderExamplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleRecordSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleRecordsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asynchronousReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeNonQryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oLEDBConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRelationExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataReaderExamplesToolStripMenuItem,
            this.codeUseToolStripMenuItem,
            this.dataRelationToolStripMenuItem,
            this.bindingNavigatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataReaderExamplesToolStripMenuItem
            // 
            this.dataReaderExamplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleRecordSetToolStripMenuItem,
            this.multipleRecordsetToolStripMenuItem,
            this.bindingSourceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.mARSToolStripMenuItem,
            this.asynchronousReaderToolStripMenuItem,
            this.executeNonQryToolStripMenuItem});
            this.dataReaderExamplesToolStripMenuItem.Name = "dataReaderExamplesToolStripMenuItem";
            this.dataReaderExamplesToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.dataReaderExamplesToolStripMenuItem.Text = "Connected-DataReader";
            // 
            // singleRecordSetToolStripMenuItem
            // 
            this.singleRecordSetToolStripMenuItem.Name = "singleRecordSetToolStripMenuItem";
            this.singleRecordSetToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.singleRecordSetToolStripMenuItem.Text = "DataTable Example";
            this.singleRecordSetToolStripMenuItem.Click += new System.EventHandler(this.singleRecordSetToolStripMenuItem_Click);
            // 
            // multipleRecordsetToolStripMenuItem
            // 
            this.multipleRecordsetToolStripMenuItem.Name = "multipleRecordsetToolStripMenuItem";
            this.multipleRecordsetToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.multipleRecordsetToolStripMenuItem.Text = "Multiple Recordset";
            this.multipleRecordsetToolStripMenuItem.Click += new System.EventHandler(this.multipleRecordsetToolStripMenuItem_Click);
            // 
            // bindingSourceToolStripMenuItem
            // 
            this.bindingSourceToolStripMenuItem.Name = "bindingSourceToolStripMenuItem";
            this.bindingSourceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bindingSourceToolStripMenuItem.Text = "BindingSource";
            this.bindingSourceToolStripMenuItem.Click += new System.EventHandler(this.bindingSourceToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // mARSToolStripMenuItem
            // 
            this.mARSToolStripMenuItem.Name = "mARSToolStripMenuItem";
            this.mARSToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.mARSToolStripMenuItem.Text = "MARS";
            this.mARSToolStripMenuItem.Click += new System.EventHandler(this.mARSToolStripMenuItem_Click);
            // 
            // asynchronousReaderToolStripMenuItem
            // 
            this.asynchronousReaderToolStripMenuItem.Name = "asynchronousReaderToolStripMenuItem";
            this.asynchronousReaderToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.asynchronousReaderToolStripMenuItem.Text = "Asynchronous Reader";
            this.asynchronousReaderToolStripMenuItem.Click += new System.EventHandler(this.asynchronousReaderToolStripMenuItem_Click);
            // 
            // executeNonQryToolStripMenuItem
            // 
            this.executeNonQryToolStripMenuItem.Name = "executeNonQryToolStripMenuItem";
            this.executeNonQryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.executeNonQryToolStripMenuItem.Text = "ExecuteNonQry";
            this.executeNonQryToolStripMenuItem.Click += new System.EventHandler(this.executeNonQryToolStripMenuItem_Click);
            // 
            // codeUseToolStripMenuItem
            // 
            this.codeUseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataGridToolStripMenuItem,
            this.insertCommandToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.oLEDBConnectionToolStripMenuItem,
            this.navigateExampleToolStripMenuItem,
            this.bulkCopyToolStripMenuItem,
            this.bindingSourceToolStripMenuItem1});
            this.codeUseToolStripMenuItem.Name = "codeUseToolStripMenuItem";
            this.codeUseToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.codeUseToolStripMenuItem.Text = "Disconnected";
            // 
            // dataGridToolStripMenuItem
            // 
            this.dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            this.dataGridToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dataGridToolStripMenuItem.Text = "DataSet";
            this.dataGridToolStripMenuItem.Click += new System.EventHandler(this.dataGridToolStripMenuItem_Click);
            // 
            // insertCommandToolStripMenuItem
            // 
            this.insertCommandToolStripMenuItem.Name = "insertCommandToolStripMenuItem";
            this.insertCommandToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.insertCommandToolStripMenuItem.Text = "Insert Command";
            this.insertCommandToolStripMenuItem.Click += new System.EventHandler(this.insertCommandToolStripMenuItem_Click);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.navigateToolStripMenuItem.Text = "Binding textBox";
            this.navigateToolStripMenuItem.Click += new System.EventHandler(this.navigateToolStripMenuItem_Click);
            // 
            // oLEDBConnectionToolStripMenuItem
            // 
            this.oLEDBConnectionToolStripMenuItem.Name = "oLEDBConnectionToolStripMenuItem";
            this.oLEDBConnectionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.oLEDBConnectionToolStripMenuItem.Text = "OLEDB Connection";
            this.oLEDBConnectionToolStripMenuItem.Click += new System.EventHandler(this.oLEDBConnectionToolStripMenuItem_Click);
            // 
            // navigateExampleToolStripMenuItem
            // 
            this.navigateExampleToolStripMenuItem.Name = "navigateExampleToolStripMenuItem";
            this.navigateExampleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.navigateExampleToolStripMenuItem.Text = "Navigate Example";
            this.navigateExampleToolStripMenuItem.Click += new System.EventHandler(this.navigateExampleToolStripMenuItem_Click);
            // 
            // bulkCopyToolStripMenuItem
            // 
            this.bulkCopyToolStripMenuItem.Name = "bulkCopyToolStripMenuItem";
            this.bulkCopyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bulkCopyToolStripMenuItem.Text = "BulkCopy";
            this.bulkCopyToolStripMenuItem.Click += new System.EventHandler(this.bulkCopyToolStripMenuItem_Click);
            // 
            // bindingSourceToolStripMenuItem1
            // 
            this.bindingSourceToolStripMenuItem1.Name = "bindingSourceToolStripMenuItem1";
            this.bindingSourceToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.bindingSourceToolStripMenuItem1.Text = "Binding_Source";
            this.bindingSourceToolStripMenuItem1.Click += new System.EventHandler(this.bindingSourceToolStripMenuItem1_Click);
            // 
            // dataRelationToolStripMenuItem
            // 
            this.dataRelationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataRelationExampleToolStripMenuItem});
            this.dataRelationToolStripMenuItem.Name = "dataRelationToolStripMenuItem";
            this.dataRelationToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.dataRelationToolStripMenuItem.Text = "Data_Relation";
            // 
            // dataRelationExampleToolStripMenuItem
            // 
            this.dataRelationExampleToolStripMenuItem.Name = "dataRelationExampleToolStripMenuItem";
            this.dataRelationExampleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.dataRelationExampleToolStripMenuItem.Text = "Data_Relation_Example";
            this.dataRelationExampleToolStripMenuItem.Click += new System.EventHandler(this.dataRelationExampleToolStripMenuItem_Click);
            // 
            // bindingNavigatorToolStripMenuItem
            // 
            this.bindingNavigatorToolStripMenuItem.Name = "bindingNavigatorToolStripMenuItem";
            this.bindingNavigatorToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.bindingNavigatorToolStripMenuItem.Text = "BindingNavigator";
            this.bindingNavigatorToolStripMenuItem.Click += new System.EventHandler(this.bindingNavigatorToolStripMenuItem_Click);
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

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataReaderExamplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleRecordSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleRecordsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindingSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asynchronousReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oLEDBConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeNonQryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindingSourceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataRelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRelationExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bindingNavigatorToolStripMenuItem;
    }
}



