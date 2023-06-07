namespace C_小区物业管理
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripButton();
            this.RealButton = new System.Windows.Forms.ToolStripButton();
            this.OwnerButton = new System.Windows.Forms.ToolStripButton();
            this.DrivewayButton = new System.Windows.Forms.ToolStripButton();
            this.SQLTABLE = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLTABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.RealButton,
            this.OwnerButton,
            this.DrivewayButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(9, 6, 0, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 10);
            this.toolStrip1.Size = new System.Drawing.Size(189, 595);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripProgressBar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 56F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.toolStripProgressBar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(184, 4);
            this.toolStripProgressBar1.Text = "楼盘信息维护";
            this.toolStripProgressBar1.ToolTipText = "楼盘信息维护";
            // 
            // RealButton
            // 
            this.RealButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RealButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.RealButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RealButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 4);
            this.RealButton.Name = "RealButton";
            this.RealButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.RealButton.Size = new System.Drawing.Size(184, 40);
            this.RealButton.Text = "楼盘信息维护";
            this.RealButton.Click += new System.EventHandler(this.RealButton_Click);
            // 
            // OwnerButton
            // 
            this.OwnerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OwnerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.OwnerButton.Image = ((System.Drawing.Image)(resources.GetObject("OwnerButton.Image")));
            this.OwnerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OwnerButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 4);
            this.OwnerButton.Name = "OwnerButton";
            this.OwnerButton.Size = new System.Drawing.Size(184, 40);
            this.OwnerButton.Text = "业主信息维护";
            this.OwnerButton.Click += new System.EventHandler(this.OwnerButton_Click);
            // 
            // DrivewayButton
            // 
            this.DrivewayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrivewayButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.DrivewayButton.Image = ((System.Drawing.Image)(resources.GetObject("DrivewayButton.Image")));
            this.DrivewayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrivewayButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 4);
            this.DrivewayButton.Name = "DrivewayButton";
            this.DrivewayButton.Size = new System.Drawing.Size(184, 40);
            this.DrivewayButton.Text = "车位信息维护";
            this.DrivewayButton.Click += new System.EventHandler(this.DrivewayButton_Click);
            // 
            // SQLTABLE
            // 
            this.SQLTABLE.AllowUserToOrderColumns = true;
            this.SQLTABLE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SQLTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLTABLE.Location = new System.Drawing.Point(215, 26);
            this.SQLTABLE.Name = "SQLTABLE";
            this.SQLTABLE.RowHeadersWidth = 72;
            this.SQLTABLE.RowTemplate.Height = 33;
            this.SQLTABLE.Size = new System.Drawing.Size(1061, 519);
            this.SQLTABLE.TabIndex = 4;
            this.SQLTABLE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SQLTABLE_CellContentClick);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 595);
            this.Controls.Add(this.SQLTABLE);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Information";
            this.Text = "基本信息维护";
            this.Load += new System.EventHandler(this.Finance_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLTABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton RealButton;
        private System.Windows.Forms.ToolStripButton OwnerButton;
        private System.Windows.Forms.ToolStripButton DrivewayButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView SQLTABLE;
    }
}