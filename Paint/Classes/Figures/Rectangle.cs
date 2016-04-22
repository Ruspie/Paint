using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Rectangle: Shape
    {
        public Rectangle(Point topLeftPoint, int width, int heigth, Color color, int penWidth)
        {
            this.TopLeftPoint = topLeftPoint;
            this.Width = width;
            this.Heigth = heigth;
            this.Color = color;
            this.PenWidth = penWidth;
        }

        public Rectangle() { }

        public Point TopLeftPoint { get; }

        public int Width { get; }

        public int Heigth { get; }
    }
}
