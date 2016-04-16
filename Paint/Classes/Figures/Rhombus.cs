using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Rhombus: Shape
    {
        public Rhombus(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint, Color color)
        {
            this.Color = color;
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
            this.ThirdPoint = thirdPoint;
            this.FourthPoint = fourthPoint;
        }

        public Point FirstPoint { get; }
        public Point SecondPoint { get; }
        public Point ThirdPoint { get; }
        public Point FourthPoint { get; }
    }
}
