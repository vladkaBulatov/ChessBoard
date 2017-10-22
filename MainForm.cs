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
    public partial class MainForm : Form
    {
        ChessBoard ChessBoard;
        
        public MainForm()
        {   
            InitializeComponent();
            picture.Width = picture.Height;
        }

        private void PicturePaint(object sender, PaintEventArgs e)
        {
            var bmp = new Bitmap(picture.Width, picture.Height);
            var graph = Graphics.FromImage(bmp);
            ChessBoard = new ChessBoard(graph);
            var x = 3;
            var y = x;
            
            ChessBoard.Height = picture.Height - x ;
            ChessBoard.Width = picture.Width - y;

            ChessBoard.X = x;
            ChessBoard.Y = y;

            ChessBoard.CreateCells();
            ChessBoard.CreateCheckers();
            picture.Image = bmp;
        }


        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            picture.Height = Math.Min(this.Height - 100, this.Width - 200);
            picture.Width = picture.Height;
        }
    }
}
