using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шахматная_доска
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //DrawEllipse(486, 158, 40, 40);
            Draw();
        }
        
        private void DrawEllipse(int x, int y, int rx, int ry)
        {
            Bitmap bmp1 = new Bitmap(picture.Width, picture.Height);
            Pen pen = new Pen(Color.Black);
            Graphics graph1 = Graphics.FromImage(bmp1);
            Rectangle rect = new Rectangle(x, y, rx, ry);
            graph1.DrawEllipse(pen, rect);

            picture.Image = bmp1;

            
        }

        public void Draw()
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            //Color.FromArgb(255, 255, 0, 0));


            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            // шашка

            graph.FillRectangle(solidBrush, 10, 10, 100, 100);
            //оконтовка
            graph.DrawLine(pen, 10, 10, 446, 10);
            graph.DrawLine(pen, 10, 10, 10, 446);
            graph.DrawLine(pen, 10, 446, 446, 446);
            graph.DrawLine(pen, 446, 10, 446, 446);
            //горизонтальные линии
            graph.DrawLine(pen, 40, 40, 416, 40);
            graph.DrawLine(pen, 40, 87, 416, 87);
            graph.DrawLine(pen, 40, 134, 416, 134);
            graph.DrawLine(pen, 40, 181, 416, 181);
            graph.DrawLine(pen, 40, 228, 416, 228);
            graph.DrawLine(pen, 40, 275, 416, 275);
            graph.DrawLine(pen, 40, 322, 416, 322);
            graph.DrawLine(pen, 40, 369, 416, 369);
            graph.DrawLine(pen, 40, 416, 416, 416);
            //вертикальные линии
            graph.DrawLine(pen, 40, 40, 40, 416);
            graph.DrawLine(pen, 87, 40, 87, 416);
            graph.DrawLine(pen, 134, 40, 134, 416);
            graph.DrawLine(pen, 181, 40, 181, 416);
            graph.DrawLine(pen, 228, 40, 228, 416);
            graph.DrawLine(pen, 275, 40, 275, 416);
            graph.DrawLine(pen, 322, 40, 322, 416);
            graph.DrawLine(pen, 369, 40, 369, 416);
            graph.DrawLine(pen, 416, 40, 416, 416);

            
            
            

            picture.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
