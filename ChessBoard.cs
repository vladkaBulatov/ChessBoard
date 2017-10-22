using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шахматная_доска
{
    public class ChessBoard
    {
        public List<Cell> Cells { get; set; }
        public List<Checker> Checkers { get; set; }
        public Frame Frame { get; set; }
        #region размеры
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        #endregion размеры
        Graphics Graph { get; set; }

        public ChessBoard (Graphics graph)
        {   
            Cells = new List<Cell>();
            Checkers = new List<Checker>();
            Frame = new Frame ();
            this.Graph = graph;
        }

        public void CreateCells()
        {
            var cells = new List<Cell>();
            for (int i = 0; i < 64; i++)
            {   
                var heightCell = Height/8;
                var widthCell = heightCell;
                var numberColumn = i % 8;
                var numberString = (int)Math.Floor(i / 8.0);
                var color = (numberString + numberColumn) % 2 == 0 ? Color.Black : Color.White;
                var xCell = X + widthCell * numberColumn;
                var yCell = Y + heightCell * numberString;
                
                var cell = new Cell(color, Graph);
                cell.X = xCell;
                cell.Y = yCell;

                cell.Height = heightCell;
                cell.Width = widthCell;
                
                cell.DrawCell();
                cells.Add(cell);
            }
            
        }

        public void CreateCheckers()
        {
            var xChecker = Height / 8;
            var yChecker = xChecker;
            var checkers = new List<Checker>();
            Color color = Color.Red;
            var checker = new Checker(color, Graph);
            checker.X = xChecker / 8;
            checker.Y = checker.X;
            checker.Height = xChecker - 20;
            checker.Width = checker.Height;

            checker.DrawChecker();
            checkers.Add(checker);
        }
    }
}
