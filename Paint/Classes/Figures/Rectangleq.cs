using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Rectangleq: Shape
    {
        private readonly Point _topLeftPoint;

        public Rectangleq(Point topLeftPoint, float width, float heigth, Color color)
        {
            this._topLeftPoint = topLeftPoint;
            this.GetWidth = width;
            this.GetHeigth = heigth;
            this.Color = color;
        }

        public float GetTopLeftPointX => _topLeftPoint.X;
        public float GetTopLeftPointY => _topLeftPoint.Y;
        public float GetWidth { get; }

        public float GetHeigth { get; }
    }
}
