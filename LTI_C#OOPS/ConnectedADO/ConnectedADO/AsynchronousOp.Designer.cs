namespace ConnectedADO
{
    partial class AsynchronousOp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Step2 = new System.Windows.Forms.Button();
            this.Step1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Step2
            // 
            this.Step2.Location = new System.Drawing.Point(145, 33);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(75, 23);
            this.Step2.TabIndex = 2;
            this.Step2.Text = "Step2";
            this.Step2.UseVisualStyleBackColor = true;
            this.Step2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Step1
            // 
            this.Step1.Location = new System.Drawing.Point(251, 208);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(75, 23);
            this.Step1.TabIndex = 3;
            this.Step1.Text = "Show data";
            this.Step1.UseVisualStyleBackColor = true;
            this.Step1.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // AsynchronousOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "AsynchronousOp";
            this.Text = "Asynchronous";
            this.Load += new System.EventHandler(this.Asynchronous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Step2;
        private System.Windows.Forms.Button Step1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}