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
            this.GetTopLeftPoint = topLeftPoint;
            this.GetWidth = width;
            this.GetHeigth = heigth;
            this.Color = color;
        }

        public Point GetTopLeftPoint { get; }

        public float GetWidth { get; }

        public float GetHeigth { get; }
    }
}
