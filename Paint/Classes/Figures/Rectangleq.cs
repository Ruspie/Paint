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
        private readonly float _width;
        private readonly float _heigth;

        public Rectangleq(Point topLeftPoint, float width, float heigth, Color color)
        {
            this._topLeftPoint = topLeftPoint;
            this._width = width;
            this._heigth = heigth;
            this.Color = color;
        }

        public float GetTopLeftPointX => _topLeftPoint.X;
        public float GetTopLeftPointY => _topLeftPoint.Y;
        public float GetWidth => _width;
        public float GetHeigth => _heigth;

    }
}
