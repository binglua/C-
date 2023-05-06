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

        private void Myinterface_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox1.Image = Image.FromFile("E:\\C#项目\\C#小区物业管理\\Resources\\1.png");
            Userlabel.Text = new Login().user();
            

        }

        private void SetinformationlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setinfo setinfo = new setinfo();
            setinfo.Show();
            Close();
        }

        private void interfacelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetUI().Show();
        }
    }
}
