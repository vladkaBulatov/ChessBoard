using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Шахматная_доска
{
    public class Checker
    {
        Color Color { get; set; }
        public int Diametr { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        Graphics Graph;
        public Checker()
        {

        }

        public Checker(Color color, Graphics graph)
        {
            this.Color = color;
            this.Graph = graph;
        }

        public void DrawChecker()
        { 
            Graph.FillEllipse(new SolidBrush(Color), X, Y, Height, Width);
        }
    }
}
