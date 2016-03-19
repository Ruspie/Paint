using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Triangle: Shape
    {
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
        {
            this.GetFirstPoint = firstPoint;
            this.GetSecondPoint = secondPoint;
            this.GetThirdPoint = thirdPoint;
            this.Color = color;
        }

        public Point GetFirstPoint { get; }

        public Point GetSecondPoint { get; }

        public Point GetThirdPoint { get; }
    }
}
