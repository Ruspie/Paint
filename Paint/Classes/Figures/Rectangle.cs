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
        public Rectangle(Point topLeftPoint, float width, float heigth, Color color)
        {
            this.TopLeftPoint = topLeftPoint;
            this.Width = width;
            this.Heigth = heigth;
            this.Color = color;
        }

        public Rectangle() { }

        public Point TopLeftPoint { get; }

        public float Width { get; }

        public float Heigth { get; }
    }
}
