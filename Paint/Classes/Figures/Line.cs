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
        public Line(Point firstPoint, Point secondPoint, Color color)
        {
            this.GetFirstPoint = firstPoint;
            this.GetSecondPoint = secondPoint;
            this.Color = color;
        }

        public Point GetFirstPoint { get; }

        public Point GetSecondPoint { get; }
    }
}
