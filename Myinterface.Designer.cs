namespace C_小区物业管理
{
    partial class Myinterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myinterface));
            this.Userlabel = new System.Windows.Forms.Label();
            this.interfacelinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SetinformationlinkLabel = new System.Windows.Forms.LinkLabel();
            this.BasiclinkLabel = new System.Windows.Forms.LinkLabel();
            this.financelinkLabel = new System.Windows.Forms.LinkLabel();
            this.CustomerlinkLabel = new System.Windows.Forms.LinkLabel();
            this.personnellinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("宋体", 15F);
            this.Userlabel.Location = new System.Drawing.Point(185, 56);
            this.Userlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(87, 35);
            this.Userlabel.TabIndex = 1;
            this.Userlabel.Text = "uesr";
            // 
            // interfacelinkLabel
            // 
            this.interfacelinkLabel.AutoSize = true;
            this.interfacelinkLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.interfacelinkLabel.LinkColor = System.Drawing.Color.Black;
            this.interfacelinkLabel.Location = new System.Drawing.Point(1740, 16);
            this.interfacelinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.interfacelinkLabel.Name = "interfacelinkLabel";
            this.interfacelinkLabel.Size = new System.Drawing.Size(106, 24);
            this.interfacelinkLabel.TabIndex = 2;
            this.interfacelinkLabel.TabStop = true;
            this.interfacelinkLabel.Text = "界面管理";
            this.interfacelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.interfacelinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(-15, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2463, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // SetinformationlinkLabel
            // 
            this.SetinformationlinkLabel.AutoSize = true;
            this.SetinformationlinkLabel.Font = new System.Drawing.Font("宋体", 17F);
            this.SetinformationlinkLabel.LinkColor = System.Drawing.Color.Black;
            this.SetinformationlinkLabel.Location = new System.Drawing.Point(154, 329);
            this.SetinformationlinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SetinformationlinkLabel.Name = "SetinformationlinkLabel";
            this.SetinformationlinkLabel.Size = new System.Drawing.Size(177, 40);
            this.SetinformationlinkLabel.TabIndex = 4;
            this.SetinformationlinkLabel.TabStop = true;
            this.SetinformationlinkLabel.Text = "修改信息";
            this.SetinformationlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetinformationlinkLabel_LinkClicked);
            // 
            // BasiclinkLabel
            // 
            this.BasiclinkLabel.AutoSize = true;
            this.BasiclinkLabel.Font = new System.Drawing.Font("宋体", 17F);
            this.BasiclinkLabel.LinkColor = System.Drawing.Color.Black;
            this.BasiclinkLabel.Location = new System.Drawing.Point(154, 564);
            this.BasiclinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BasiclinkLabel.Name = "BasiclinkLabel";
            this.BasiclinkLabel.Size = new System.Drawing.Size(257, 40);
            this.BasiclinkLabel.TabIndex = 5;
            this.BasiclinkLabel.TabStop = true;
            this.BasiclinkLabel.Text = "基本信息维护";
            // 
            // financelinkLabel
            // 
            this.financelinkLabel.AutoSize = true;
            this.financelinkLabel.Font = new System.Drawing.Font("宋体", 17F);
            this.financelinkLabel.LinkColor = System.Drawing.Color.Black;
            this.financelinkLabel.Location = new System.Drawing.Point(873, 329);
            this.financelinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.financelinkLabel.Name = "financelinkLabel";
            this.financelinkLabel.Size = new System.Drawing.Size(177, 40);
            this.financelinkLabel.TabIndex = 6;
            this.financelinkLabel.TabStop = true;
            this.financelinkLabel.Text = "财务管理";
            // 
            // CustomerlinkLabel
            // 
            this.CustomerlinkLabel.AutoSize = true;
            this.CustomerlinkLabel.Font = new System.Drawing.Font("宋体", 17F);
            this.CustomerlinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CustomerlinkLabel.Location = new System.Drawing.Point(1573, 329);
            this.CustomerlinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CustomerlinkLabel.Name = "CustomerlinkLabel";
            this.CustomerlinkLabel.Size = new System.Drawing.Size(177, 40);
            this.CustomerlinkLabel.TabIndex = 8;
            this.CustomerlinkLabel.TabStop = true;
            this.CustomerlinkLabel.Text = "客服管理";
            // 
            // personnellinkLabel
            // 
            this.personnellinkLabel.AutoSize = true;
            this.personnellinkLabel.Font = new System.Drawing.Font("宋体", 17F);
            this.personnellinkLabel.LinkColor = System.Drawing.Color.Black;
            this.personnellinkLabel.Location = new System.Drawing.Point(873, 564);
            this.personnellinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.personnellinkLabel.Name = "personnellinkLabel";
            this.personnellinkLabel.Size = new System.Drawing.Size(257, 40);
            this.personnellinkLabel.TabIndex = 9;
            this.personnellinkLabel.TabStop = true;
            this.personnellinkLabel.Text = "人员信息维护";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::C_小区物业管理.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Myinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2074, 1202);
            this.Controls.Add(this.personnellinkLabel);
            this.Controls.Add(this.CustomerlinkLabel);
            this.Controls.Add(this.financelinkLabel);
            this.Controls.Add(this.BasiclinkLabel);
            this.Controls.Add(this.SetinformationlinkLabel);
            this.Controls.Add(this.interfacelinkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Myinterface";
            this.Text = "我的";
            this.Load += new System.EventHandler(this.Myinterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.LinkLabel interfacelinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel SetinformationlinkLabel;
        private System.Windows.Forms.LinkLabel BasiclinkLabel;
        private System.Windows.Forms.LinkLabel financelinkLabel;
        private System.Windows.Forms.LinkLabel CustomerlinkLabel;
        private System.Windows.Forms.LinkLabel personnellinkLabel;
    }
}