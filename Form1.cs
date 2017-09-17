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
        ChessBoard ChessBoard;

        public Form1()
        {
            InitializeComponent();
            var bmp = new Bitmap(picture.Width, picture.Height);
            var graph = Graphics.FromImage(bmp);
            ChessBoard = new ChessBoard(graph);
            var x = 20;
            var y = 20;
            var width = picture.Width;
            var height = picture.Height;
            ChessBoard.Width = width;
            ChessBoard.Height = height;
            ChessBoard.X = x;
            ChessBoard.Y = y;
            
            ChessBoard.CreateCells();
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

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            picture.Width = Math.Min(this.Width, this.Height) + 50;
            picture.Height = Math.Min(this.Width, this.Height) + 50;
        }

        private void picture_SizeChanged(object sender, EventArgs e )
        {

        }
    }
}
