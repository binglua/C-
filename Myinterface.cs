using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_小区物业管理
{
    public partial class Myinterface : Form
    {
        //加载本窗口时
        private void Myinterface_Load(object sender, EventArgs e)
        {
            //设置背景图片和窗口大小一致
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //绘制LOGO图片为圆形
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            //获取当前登录用户名
            Userlabel.Text = new Login().user();
            //每次打开获取LOGO
            //SetLOGO();

        }


        public Myinterface()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            rg.Dispose();
            gp.Dispose();
        }
        public void SetLOGO(Image image)
        {
            pictureBox1.Image = image;
        }
        public void ChangeBackgroundImage(Image image)
        {
            this.BackgroundImage = image;
        }

        //打开修改信息窗口
        private void SetinformationlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setinfo setinfo = new setinfo();
            setinfo.Show();
            
        }
        //打开界面管理窗口
        private void interfacelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetUI setUI = new SetUI();
            setUI.Owner = this; // 将Myinterface窗口本身作为Owner属性传递给SetUI窗口
            setUI.ShowDialog();
        }
        //打开财务管理
        private void financelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new finance().ShowDialog();
        }
        //打开基本信息维护
        private void BasiclinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Information().ShowDialog();
        }
        //打开客服页面
        private void CustomerlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Customer().ShowDialog();
        }
        //打开人员信息维护
        private void personnellinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new personnel().ShowDialog();
        }
        //关闭该窗口时退出整个程序
        private void Myinterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
