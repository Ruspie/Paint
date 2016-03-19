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
        private readonly Point _firstPoint;
        private readonly Point _secondPoint;

        public Line(Point firstPoint, Point secondPoint, Color color)
        {
            this._firstPoint = firstPoint;
            this._secondPoint = secondPoint;
            this.Color = color;
        }

        public Point GetFirstPoint => _firstPoint;
        public Point GetSecondPoint => _secondPoint;
    }
}
