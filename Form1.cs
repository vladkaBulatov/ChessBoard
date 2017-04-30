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
            picture.Width = Math.Min(this.Width, this.Height) - 50;
            picture.Height = Math.Min(this.Width, this.Height) - 50;

            Chessboard();
            
            
        }
        public void Chessboard()
        {
            SolidBrush solidBrushBlack = new SolidBrush(Color.Black);
            SolidBrush solidBrushWhite = new SolidBrush(Color.White);
            SolidBrush myBrushBlue = new SolidBrush(Color.Blue);
            SolidBrush myBrushGold = new SolidBrush(Color.Gold);
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);

            var indentX = 20;
            var indentY = 20;
            var pointStartDrawChessboard = new Point(indentX, indentY);
            var frameWidth = Math.Min(picture.Width, picture.Height) - 2 * pointStartDrawChessboard.X;
            var thicknessFrame = pointStartDrawChessboard.X * 2;

            CreateFrame(graph, pen, pointStartDrawChessboard.X, pointStartDrawChessboard.Y, frameWidth, thicknessFrame);

            var NumberCellsRow = 8;
            float cellSideLength = (frameWidth - 2 * thicknessFrame) / NumberCellsRow;

            for (int numberString = 0; numberString < NumberCellsRow; numberString++)
                for (int numberColumn = 0; numberColumn < NumberCellsRow; numberColumn++)
                {
                    SolidBrush solidBrush = new SolidBrush((numberString + numberColumn) % 2 == 0 ? Color.Black : Color.White);

                    CreateCell(graph,
                        solidBrush,
                        pointStartDrawChessboard.X + (numberColumn * cellSideLength) + thicknessFrame,
                        pointStartDrawChessboard.Y + (numberString * cellSideLength) + thicknessFrame,
                        cellSideLength
                    );
                }
            for (int numberString = 0; numberString < NumberCellsRow; numberString++)
                for (int checkerNumber = 0; checkerNumber < NumberCellsRow / 2; checkerNumber ++)
                {
                GreateСheckers(graph,
                    myBrushBlue,
                    pointStartDrawChessboard.X + ((NumberCellsRow / 2) + (cellSideLength * checkerNumber) * 2) + thicknessFrame,
                    pointStartDrawChessboard.Y + (NumberCellsRow / 2) + cellSideLength,
                    cellSideLength - 10,
                    cellSideLength - 10);
                }
            //GreateСheckers(graph, myBrushBlue, 66, 66, 30, 30);
            //GreateСheckers(graph, myBrushBlue, 156, 66, 30, 30);
            //GreateСheckers(graph, myBrushBlue, 246, 66, 30, 30);
            //GreateСheckers(graph, myBrushBlue, 336, 66, 30, 30);



            picture.Image= bmp;
        }
        public void GreateСheckers(Graphics graph, SolidBrush myBrushBlue, float x, float y, float d, float d1)
        {
            graph.FillEllipse(myBrushBlue, x, y, d, d1); 
        }

        private static void CreateCell(Graphics graph, SolidBrush solidBrush, float x, float y, float sizeSquare)
        {
            //если не будет больше никаких действий можно не использовать фукнцию CreateCell
            graph.FillRectangle( solidBrush, x, y, sizeSquare, sizeSquare);
        }

        private static void CreateField(Graphics graph, Pen pen, SolidBrush solidBrush, float x, float y, float sizeSquare)
        {
            
        }
        

        private static void CreateFrame(Graphics graph, Pen pen, float x, float y, float widthEdging, float thicknessEdging)
        {
            graph.DrawRectangle(pen, x, y, widthEdging, widthEdging);
           // graph.DrawRectangle(pen, x + thicknessEdging, y + thicknessEdging, widthEdging - 2 * thicknessEdging, widthEdging - 2 * thicknessEdging);
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
