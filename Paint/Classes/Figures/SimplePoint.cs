using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class SimplePoint : Shape
    {
        public SimplePoint(Point point)
        {
            this.CenterPoint = point;
        }
        public Point CenterPoint { get; set; } 
    }
}
