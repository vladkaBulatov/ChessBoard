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
        
        public Checker(Color color)
        {
            this.Color = color;
        }
    }
}
