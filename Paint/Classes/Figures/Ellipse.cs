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
        private readonly Point centerPoint;
        private readonly float radiusX;
        private readonly float radiusY;

        public Ellipse(Point CenterPoint, float RadiusX, float RadiusY, Color Color)
        {
            this.centerPoint = CenterPoint;
            this.radiusX = RadiusX;
            this.radiusY = RadiusY;
            this.color = Color;
        }

        public float GetCenterX => centerPoint.X;
        public float GetCenterY => centerPoint.Y;
        public float GetRadiusX => radiusX;

        public float GetRadiusY => radiusY;
    }
}
