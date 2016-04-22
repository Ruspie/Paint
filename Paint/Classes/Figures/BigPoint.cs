using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class BigPoint : Shape
    {
        public BigPoint(Point firstPoint, Color color, int penWidth)
        {
            this.FirstPoint = firstPoint;
            this.Color = color;
            this.PenWidth = penWidth;
        }

        public BigPoint()
        {
            
        }

        public Point FirstPoint { get; }
    }
}
