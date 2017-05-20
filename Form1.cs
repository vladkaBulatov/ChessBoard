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
        Cell Cell;

        public Form1()
        {
            InitializeComponent();
            var bmp = new Bitmap(picture.Width, picture.Height);
            var graph = Graphics.FromImage(bmp);
            ChessBoard = new ChessBoard(graph);
            Cell = new Cell();
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
            //CreateChessboard();

        }
        /*public void CreateChessboard()
        {
            var solidBrushBlack = new SolidBrush(Color.Black);
            var solidBrushWhite = new SolidBrush(Color.White);
            var myBrushBlue = new SolidBrush(Color.Blue);
            var myBrushGold = new SolidBrush(Color.Gold);
            var bmp = new Bitmap(picture.Width, picture.Height);
            var graph = Graphics.FromImage(bmp);
            var pen = new Pen(Color.Black);

            var indentX = 20;
            var indentY = 20;
            var pointStartDrawChessboard = new Point(indentX, indentY);
            var thicknessFrame = pointStartDrawChessboard.X * 2;
            var pointStartDrawCellsOnBoard = new Point(pointStartDrawChessboard.X + thicknessFrame, pointStartDrawChessboard.Y + thicknessFrame);
            var frameWidth = Math.Min(picture.Width, picture.Height) - 2 * pointStartDrawChessboard.X;
            var numberCellsRow = 8;            
            var cellSideLength = Convert.ToInt32((frameWidth - 2 * thicknessFrame) / numberCellsRow);
            var diameterСhecker = cellSideLength - 10;

            CreateFrame(graph, pen, pointStartDrawChessboard.X, pointStartDrawChessboard.Y, frameWidth, thicknessFrame);
            CreateCells(graph, pointStartDrawCellsOnBoard, cellSideLength, numberCellsRow, thicknessFrame);
            CreateСheckers(graph, myBrushBlue, pointStartDrawCellsOnBoard, cellSideLength, numberCellsRow, diameterСhecker);

            picture.Image= bmp;
        }*/


        private void CreateCell(Graphics graph, SolidBrush solidBrush, float x, float y, float sizeSquare)
        {            
            graph.FillRectangle( solidBrush, x, y, sizeSquare, sizeSquare);
        }

       /*private void CreateCells(Graphics graph, Point pointStartDraw, float cellSideLength, int numberCellsRow, int thicknessFrame)
       {
            var blackBrash = new SolidBrush(Color.Black);
            var whiteBrash = new SolidBrush(Color.White);

            for (int numberString = 0; numberString < numberCellsRow; numberString++)//рисование строк с ячейками в столбик
                for (int numberColumn = 0; numberColumn < numberCellsRow; numberColumn++)//рисование одной строки с ячейками
                {
                    var brush = (numberString + numberColumn) % 2 == 0 ? blackBrash : whiteBrash;
                    CreateCell(graph,
                        brush,
                        pointStartDraw.X + numberColumn * cellSideLength,
                        pointStartDraw.Y + numberString * cellSideLength,
                        cellSideLength
                    );
                }
        }*/
        public void CreateСhecker(Graphics graph, SolidBrush myBrushBlue, float x, float y, float diameter)
        {
            graph.FillEllipse(myBrushBlue, x, y, diameter, diameter);
        }

        public void CreateСheckers(Graphics graph, SolidBrush myBrushBlue, Point pointStartDrawChessboard, float cellSideLength, int numberCellsRow, int diameterСhecker)
        {   
            for (int numberString = 0; numberString < 3 ; numberString++)//рисовани строк с шашками в столбик
                for (int numberColumn = 0; numberColumn < numberCellsRow; numberColumn++)//рисовани одной строки с шашками
                {                    
                    if ((numberString + numberColumn) % 2 == 0)
                        CreateСhecker(graph,
                              myBrushBlue,
                              pointStartDrawChessboard.X + cellSideLength * numberColumn + (cellSideLength - diameterСhecker) / 2f,
                              pointStartDrawChessboard.Y + cellSideLength * numberString + (cellSideLength - diameterСhecker) / 2f,
                              diameterСhecker);
                }
        }

        private void CreateFrame(Graphics graph, Pen pen, float x, float y, float widthEdging, float thicknessEdging)
        {
            graph.DrawRectangle(pen, x, y, widthEdging, widthEdging);
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
