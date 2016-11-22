using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width = Screen.AllScreens[0].Bounds.Width;
            int height = Screen.AllScreens[0].Bounds.Height;

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(width, height));
                System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, 400, 300);
                g.DrawImage(bmp, rectDestination, 0, 0, width, height, GraphicsUnit.Pixel);
                g.Dispose();
            }

            MemoryStream ms = new MemoryStream();
            this.pictureBox1.Image = bmp;
            bmp.Save(ms, ImageFormat.Png);
            byte[] byteImage = new Byte[ms.Length];
            byteImage = ms.ToArray();
        }
    }
}
