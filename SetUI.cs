using System;
using System.Windows.Forms;
using System.Drawing;

namespace C_小区物业管理
{
    public partial class SetUI : Form
    {

        public SetUI()
        {
            InitializeComponent();
        }
        //设置LOGO方法
        private void SetLOGO(Image image)
        {
            Image newImage = image;
            Myinterface myinterface = (Myinterface)Owner;
            myinterface.SetLOGO(newImage);
        }
        //设置背景图的方法
        private void SetBack(Image image)
        {
            Image newImage = image;
            Myinterface myinterface = (Myinterface)this.Owner;
            myinterface.ChangeBackgroundImage(newImage);
        }

        //加载页面
        private void SetUI_Load(object sender, EventArgs e)
        {

            UIsplit.Panel2Collapsed = true;
            LOGOButton.Checked = true;
        }
        //LOGO按钮
        private void LOGOButton_Click(object sender, EventArgs e)
        {
            UIsplit.Panel2Collapsed = true;
            UIButton.Checked = false;

        }
        //主题按钮
        private void UIButton_Click(object sender, EventArgs e)
        {
            UIsplit.Panel1Collapsed = true;
            UIsplit.Panel2Collapsed = false;
            LOGOButton.Checked = false;
        }
        //LOGO图片按钮
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox3.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox4.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox5.Image);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox6.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox7.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox8.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SetLOGO(pictureBox9.Image);
        }


        //两个确定按钮
        private void Okbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        //背景图片按钮
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox10.Image);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox11.Image);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox12.Image);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox13.Image);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox14.Image);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            SetBack(pictureBox15.Image);
        }



        //选择自定义图片后
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           string photoFilePath = openFileDialog1.FileName;
            Image photoImage = Image.FromFile(photoFilePath);
            SetBack(photoImage);
        }

        //打开选择文件页面
        private void Customization_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
