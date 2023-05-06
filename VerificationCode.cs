using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace C_小区物业管理
{
    internal class VerificationCode
    {
        public static string GetSystemCaptcha(int codeLen = 4)
        {
            string code = "";
            //生成随机数字
            Random rand = new Random();
            for (int i = 0; i < codeLen; i++)
            {
                code += rand.Next(0, 9).ToString();
            }
            return code;
        }

        /// 生成验证码图片
        public static byte[] GenerateImg(string code)
        {
            Bitmap image = new Bitmap(code.Length * 15, 29);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //清空图片背景色
                g.Clear(Color.White);

                //增加背景干扰线
                Random random = new Random();
                for (int i = 0; i < 50; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    //颜色可自定义
                    g.DrawLine(new Pen(Color.FromArgb(186, 212, 231)), x1, y1, x2, y2);
                }

                //定义验证码字体
                Font font = new Font("Arial", 15, (FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout));
                //定义验证码的刷子，这里采用渐变的方式，颜色可自定义
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.FromArgb(67, 93, 230), Color.FromArgb(70, 128, 228), 1.5f, true);

                //增加干扰点
                for (int i = 0; i < 200; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    //颜色可自定义
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }

                //将验证码写入图片
                g.DrawString(code, font, brush, 5, 5);


                //图片边框
                g.DrawRectangle(new Pen(Color.FromArgb(93, 142, 228)), 0, 0, image.Width - 1, image.Height - 1);

                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }

        }
    }
}
