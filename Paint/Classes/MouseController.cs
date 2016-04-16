using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Classes
{
    class MouseController
    {
        private Point PointMouseDown;
        private Point PointMouseUp;

        public void SetPointMouseDown(MouseEventArgs e)
        {
            PointMouseDown = new Point(e.X, e.Y);
        }

        public void SetPointMouseUp(MouseEventArgs e)
        {
            PointMouseUp = new Point(e.X, e.Y);
        }

        public Point GetPointMouseDown()
        {
            return PointMouseDown;
        }

        public Point GetPointMouseUp()
        {
            return PointMouseUp;
        }
    }
}
