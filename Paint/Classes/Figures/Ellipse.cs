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
        public Ellipse(Point centerPoint, float radiusX, float radiusY, Color color)
        {
            this.GetCenterPoint = centerPoint;
            this.GetRadiusX = radiusX;
            this.GetRadiusY = radiusY;
            this.Color = color;
        }

        public Point GetCenterPoint { get; }

        public float GetRadiusX { get; }

        public float GetRadiusY { get; }
    }
}
