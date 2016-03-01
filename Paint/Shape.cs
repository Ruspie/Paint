using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public abstract class Shape
    {
        public static Color color;
        public static PointF centerPoint;

        public abstract void Draw();
    }
}
