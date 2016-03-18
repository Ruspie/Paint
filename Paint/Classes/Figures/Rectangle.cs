using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Rectangle: Shape
    {
        public readonly Point topLeftPoint;
        public readonly float width;
        public readonly float heigth;

        public Rectangle(Point TopLeftPoint, float Width, float Heigth, Color Color)
        {
            this.topLeftPoint = TopLeftPoint;
            this.width = Width;
            this.heigth = Heigth;
            this.color = Color;
        }
    }
}
