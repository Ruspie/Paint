using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Classes.Figures
{
    internal class Line: Shape
    {
        public Line(Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
            this.Color = color;
            this.PenWidth = penWidth;
        }
        
        public Line() { }

        public Point FirstPoint { get; }

        public Point SecondPoint { get; }
    }
}
