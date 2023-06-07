namespace C_小区物业管理
{
    partial class Customer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MaintenanceButton = new System.Windows.Forms.ToolStripButton();
            this.complaintsButton = new System.Windows.Forms.ToolStripButton();
            this.Customerdata = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.维修状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customerdata)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaintenanceButton,
            this.complaintsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(157, 595);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MaintenanceButton
            // 
            this.MaintenanceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MaintenanceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaintenanceButton.Margin = new System.Windows.Forms.Padding(5);
            this.MaintenanceButton.Name = "MaintenanceButton";
            this.MaintenanceButton.Size = new System.Drawing.Size(142, 44);
            this.MaintenanceButton.Text = "维修管理";
            this.MaintenanceButton.Click += new System.EventHandler(this.MaintenanceButton_Click);
            // 
            // complaintsButton
            // 
            this.complaintsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.complaintsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.complaintsButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.complaintsButton.Name = "complaintsButton";
            this.complaintsButton.Size = new System.Drawing.Size(142, 44);
            this.complaintsButton.Text = "投诉管理";
            this.complaintsButton.Click += new System.EventHandler(this.complaintsButton_Click);
            // 
            // Customerdata
            // 
            this.Customerdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Customerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customerdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.维修状态,
            this.修改});
            this.Customerdata.Location = new System.Drawing.Point(207, 63);
            this.Customerdata.Name = "Customerdata";
            this.Customerdata.RowHeadersWidth = 72;
            this.Customerdata.RowTemplate.Height = 33;
            this.Customerdata.Size = new System.Drawing.Size(1068, 483);
            this.Customerdata.TabIndex = 2;
            this.Customerdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customerdata_CellContentClick);
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "Bid";
            this.编号.FillWeight = 50F;
            this.编号.HeaderText = "编号";
            this.编号.MinimumWidth = 9;
            this.编号.Name = "编号";
            this.编号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.编号.Visible = false;
            // 
            // 维修状态
            // 
            this.维修状态.DataPropertyName = "维修状态";
            this.维修状态.HeaderText = "维修状态";
            this.维修状态.MinimumWidth = 9;
            this.维修状态.Name = "维修状态";
            this.维修状态.Visible = false;
            // 
            // 修改
            // 
            this.修改.HeaderText = "修改";
            this.修改.MinimumWidth = 9;
            this.修改.Name = "修改";
            this.修改.Text = "修改状态";
            this.修改.UseColumnTextForLinkValue = true;
            this.修改.Visible = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 595);
            this.Controls.Add(this.Customerdata);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Customer";
            this.Text = "客服管理";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customerdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MaintenanceButton;
        private System.Windows.Forms.ToolStripButton complaintsButton;
        private System.Windows.Forms.DataGridView Customerdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 维修状态;
        private System.Windows.Forms.DataGridViewLinkColumn 修改;
    }
}