using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Шахматная_доска
{
    public class Cell
    {
        public Color Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        Graphics Graph;
        public Cell()
        {
           
        }

        public Cell(Color color, Graphics graph)
        {
            this.Color = color;
            this.Graph = graph;
        }

        public void DrawCell()
        {
            Graph.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
        }
    }
}
