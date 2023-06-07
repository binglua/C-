using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace C_小区物业管理
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //单击登录按钮
        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxtBox.Text.Trim();
            string password = passwordTxtBox.Text.Trim();
            string captcha = captchaTxtBox.Text.Trim();
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请填写用户名和密码", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (!VerifyCaptcha(captcha))
            {
                
                MessageBox.Show("验证码错误，请重新输入！", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GenerateCode();

            }
            bool success = CheckUser(username, password);
            if (success&&VerifyCaptcha(captcha))
            {
                MessageBox.Show("登陆成功！", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sql = string.Format("select Zid from GuanLiYuan WHERE username='{0}' AND password='{1}'", username, password);
                
                // 登录成功，隐藏登录窗口
                this.Hide();
                //进入系统界面
                Myinterface myinterface = new Myinterface();
                myinterface.Tag = (int)DbHelper.ExecuteScalar(sql); ;
                myinterface.Show();
            }
            else
            {
                MessageBox.Show("登陆失败，请检查用户名和密码！", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        // 判断用户输入的用户名和密码是否正确
        private bool CheckUser(string username, string password)
        {
            // SQL 语句查询用户名和密码是否匹配
            string sql = string.Format("SELECT COUNT(*) FROM GuanLiYuan WHERE username='{0}' AND password='{1}'", username, password);
            int count = (int)DbHelper.ExecuteScalar(sql);

            return count > 0;

        }
        // 检查验证码是否正确
        private bool VerifyCaptcha(string inputCaptcha)
        {
            //比较输入的验证码和系统生成的验证码是否一致
            return string.Equals(inputCaptcha, systemCaptcha, StringComparison.InvariantCultureIgnoreCase);
        }

        // 获取系统生成的验证码
        public static string systemCaptcha = VerificationCode.GetSystemCaptcha();

        public void GenerateCode()
        {

            //生成验证码图片并显示到pictureBox1
            byte[] bytes = VerificationCode.GenerateImg(systemCaptcha);
            MemoryStream ms = new MemoryStream(bytes);
            Image image = Image.FromStream(ms);
            pictureBox1.Image = image;
        }
        public static string username;
        public string user()
        {
            return username;
        }
        //单击注册按钮
        private void registerBtn_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            
        }
        //单击图片
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            systemCaptcha = VerificationCode.GetSystemCaptcha();
            GenerateCode();
        }
        //加载窗口
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateCode();
    }
    }
}
