using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Шахматная_доска
{
    public class Frame
    {
        public Pen Pen;
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Frame()
        {
            Pen = new Pen(Color.Black);
        }
    }
}
