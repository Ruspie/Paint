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
        private readonly Point _firstPoint;
        private readonly Point _secondPoint;
        private readonly Point _thirdPoint;

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
        {
            this._firstPoint = firstPoint;
            this._secondPoint = secondPoint;
            this._thirdPoint = thirdPoint;
            this.Color = color;
        }

        public Point GetFirstPoint => _firstPoint;
        public Point GetSecondPoint => _secondPoint;
        public Point GetThirdPoint => _thirdPoint;

    }
}
