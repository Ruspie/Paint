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
        private Point _pointMouseDown;
        private Point _pointMouseUp;

        public void SetPointMouseDown(MouseEventArgs e)
        {
            _pointMouseDown = new Point(e.X, e.Y);
        }

        public void SetPointMouseUp(MouseEventArgs e)
        {
            _pointMouseUp = new Point(e.X, e.Y);
        }

        public Point GetPointMouseDown()
        {
            return _pointMouseDown;
        }

        public Point GetPointMouseUp()
        {
            return _pointMouseUp;
        }
    }
}
