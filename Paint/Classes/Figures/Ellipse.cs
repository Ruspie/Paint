using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paint.Classes.Figures;

namespace Paint.Classes
{
    internal class Ellipse: Shape
    {
        public Ellipse(Point firstPoint, float width, float heigth, Color color, int penWidth)
        {
            this.FirstPoint = firstPoint;
            this.Width = width;
            this.Heigth = heigth;
            this.Color = color;
            this.PenWidth = penWidth;
        }

        public Ellipse() { }

        public Point FirstPoint { get; }

        public float Width { get; }

        public float Heigth { get; }
    }
}
