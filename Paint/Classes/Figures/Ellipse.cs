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
            this.CenterPoint = centerPoint;
            this.RadiusX = radiusX;
            this.RadiusY = radiusY;
            this.Color = color;
        }

        public Point CenterPoint { get; }

        public float RadiusX { get; }

        public float RadiusY { get; }
    }
}
