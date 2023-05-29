namespace C_小区物业管理
{
    partial class finance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finance));
            this.financeData = new System.Windows.Forms.DataGridView();
            this.newitembutton = new System.Windows.Forms.Button();
            this.BillidBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.newBillbutton = new System.Windows.Forms.Button();
            this.remindbutton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.ToolStripButton();
            this.BillsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ArrearsButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.financeData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // financeData
            // 
            this.financeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financeData.Location = new System.Drawing.Point(250, 134);
            this.financeData.Name = "financeData";
            this.financeData.RowHeadersWidth = 72;
            this.financeData.RowTemplate.Height = 33;
            this.financeData.Size = new System.Drawing.Size(1010, 380);
            this.financeData.TabIndex = 1;
            // 
            // newitembutton
            // 
            this.newitembutton.Location = new System.Drawing.Point(1156, 545);
            this.newitembutton.Name = "newitembutton";
            this.newitembutton.Size = new System.Drawing.Size(134, 38);
            this.newitembutton.TabIndex = 2;
            this.newitembutton.Text = "新建收费项";
            this.newitembutton.UseVisualStyleBackColor = true;
            this.newitembutton.Visible = false;
            // 
            // BillidBox
            // 
            this.BillidBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BillidBox.Location = new System.Drawing.Point(329, 47);
            this.BillidBox.Name = "BillidBox";
            this.BillidBox.Size = new System.Drawing.Size(393, 47);
            this.BillidBox.TabIndex = 3;
            this.BillidBox.Text = "请输入编号";
            this.BillidBox.Visible = false;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(762, 47);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(108, 47);
            this.Searchbutton.TabIndex = 4;
            this.Searchbutton.Text = "搜索";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Visible = false;
            // 
            // newBillbutton
            // 
            this.newBillbutton.Location = new System.Drawing.Point(1156, 545);
            this.newBillbutton.Name = "newBillbutton";
            this.newBillbutton.Size = new System.Drawing.Size(134, 38);
            this.newBillbutton.TabIndex = 5;
            this.newBillbutton.Text = "新建收费单";
            this.newBillbutton.UseVisualStyleBackColor = true;
            this.newBillbutton.Visible = false;
            // 
            // remindbutton
            // 
            this.remindbutton.Location = new System.Drawing.Point(1156, 545);
            this.remindbutton.Name = "remindbutton";
            this.remindbutton.Size = new System.Drawing.Size(134, 38);
            this.remindbutton.TabIndex = 6;
            this.remindbutton.Text = "欠费提醒";
            this.remindbutton.UseVisualStyleBackColor = true;
            this.remindbutton.Visible = false;
            // 
            // itemsButton
            // 
            this.itemsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemsButton.Margin = new System.Windows.Forms.Padding(5);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(204, 44);
            this.itemsButton.Text = "收费项目维护";
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // BillsButton
            // 
            this.BillsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BillsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BillsButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.BillsButton.Name = "BillsButton";
            this.BillsButton.Size = new System.Drawing.Size(204, 44);
            this.BillsButton.Text = "收费单维护";
            this.BillsButton.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsButton,
            this.BillsButton,
            this.ArrearsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(219, 595);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ArrearsButton
            // 
            this.ArrearsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ArrearsButton.Image = ((System.Drawing.Image)(resources.GetObject("ArrearsButton.Image")));
            this.ArrearsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArrearsButton.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.ArrearsButton.Name = "ArrearsButton";
            this.ArrearsButton.Size = new System.Drawing.Size(204, 44);
            this.ArrearsButton.Text = "欠费提醒";
            this.ArrearsButton.Click += new System.EventHandler(this.ArrearsButton_Click);
            // 
            // finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 595);
            this.Controls.Add(this.remindbutton);
            this.Controls.Add(this.newBillbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.BillidBox);
            this.Controls.Add(this.newitembutton);
            this.Controls.Add(this.financeData);
            this.Controls.Add(this.toolStrip1);
            this.Name = "finance";
            this.Text = "财务管理";
            ((System.ComponentModel.ISupportInitialize)(this.financeData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView financeData;
        private System.Windows.Forms.Button newitembutton;
        private System.Windows.Forms.TextBox BillidBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button newBillbutton;
        private System.Windows.Forms.Button remindbutton;
        private System.Windows.Forms.ToolStripButton itemsButton;
        private System.Windows.Forms.ToolStripButton BillsButton;
        private System.Windows.Forms.ToolStripButton ArrearsButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}