using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Circle: Shape
    {
        private int radius;
        public override void Draw()
        {
            centerPoint = new PointF(37, 38);
        }
    }
}
