namespace C_小区物业管理
{
    partial class Finance
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("收费项目维护");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("收费单维护");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("欠费提醒");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "节点0";
            treeNode1.Text = "收费项目维护";
            treeNode2.Name = "节点3";
            treeNode2.Text = "收费单维护";
            treeNode3.Name = "节点4";
            treeNode3.Text = "欠费提醒";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(303, 552);
            this.treeView1.TabIndex = 0;
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 663);
            this.Controls.Add(this.treeView1);
            this.Name = "Finance";
            this.Text = "Finance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}