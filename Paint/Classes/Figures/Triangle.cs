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
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
            this.ThirdPoint = thirdPoint;
            this.Color = color;
        }

        public Point FirstPoint { get; }

        public Point SecondPoint { get; }

        public Point ThirdPoint { get; }
    }
}
