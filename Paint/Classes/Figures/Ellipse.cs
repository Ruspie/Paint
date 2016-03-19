using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes
{
    internal class Ellipse: Shape
    {
        private readonly Point _centerPoint;
        private readonly float _radiusX;
        private readonly float _radiusY;

        public Ellipse(Point centerPoint, float radiusX, float radiusY, Color color)
        {
            this._centerPoint = centerPoint;
            this._radiusX = radiusX;
            this._radiusY = radiusY;
            this.Color = color;
        }

        public float GetCenterPointX => _centerPoint.X;
        public float GetCenterPointY => _centerPoint.Y;
        public float GetRadiusX => _radiusX;

        public float GetRadiusY => _radiusY;
    }
}
