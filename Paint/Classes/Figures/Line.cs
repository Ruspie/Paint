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

        public float GetFirstPointX => _firstPoint.X;
        public float GetFirstPointY => _firstPoint.Y;
        public float GetSecondPointX => _secondPoint.X;
        public float GetSecondPointY => _secondPoint.Y;
    }
}
