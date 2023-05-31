namespace C_小区物业管理
{
    partial class personnel
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.personneldata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personneldata)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 100);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(204, 458);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "人员列表";
            // 
            // personneldata
            // 
            this.personneldata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personneldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personneldata.Location = new System.Drawing.Point(276, 100);
            this.personneldata.Name = "personneldata";
            this.personneldata.RowHeadersWidth = 72;
            this.personneldata.RowTemplate.Height = 33;
            this.personneldata.Size = new System.Drawing.Size(1005, 458);
            this.personneldata.TabIndex = 2;
            // 
            // personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 595);
            this.Controls.Add(this.personneldata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "personnel";
            this.Text = "人员信息维护";
            this.Load += new System.EventHandler(this.personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personneldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView personneldata;
    }
}