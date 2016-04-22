using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Classes
{
    internal class MouseController
    {
        private Point _pointMouseDown;
        private Point _pointMouseUp;
        public Point PointMouseLast { get; set; }
        public bool IsCLick { get; private set; }


        public Point PointMouseDown
        {
            get { return _pointMouseDown; }
            set
            {
                _pointMouseDown = value;
                IsCLick = true;
            }
        }

        public Point PointMouseUp
        {
            get { return _pointMouseUp; }
            set
            {
                _pointMouseUp = value;
                IsCLick = false;
            }
        }
    }
}
