namespace C_小区物业管理
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.captchaTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(222, 84);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(129, 21);
            this.usernameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(143, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(163, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(222, 117);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(129, 21);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(143, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "验证码:";
            // 
            // captchaTxtBox
            // 
            this.captchaTxtBox.Location = new System.Drawing.Point(222, 150);
            this.captchaTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.captchaTxtBox.Name = "captchaTxtBox";
            this.captchaTxtBox.Size = new System.Drawing.Size(66, 21);
            this.captchaTxtBox.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.loginBtn.Location = new System.Drawing.Point(116, 205);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 39);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.registerBtn.Location = new System.Drawing.Point(273, 205);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(103, 39);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Text = "注册";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 29);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.captchaTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxtBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "登录页面";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox captchaTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

