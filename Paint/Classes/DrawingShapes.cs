using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Classes
{
    internal static class DrawingShapes
    {
        private static readonly Form DrawingForm = Form.ActiveForm;
        private static readonly Graphics FormGraphics = DrawingForm.CreateGraphics();

        public static void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.color);
            FormGraphics.DrawEllipse(penColor, ellipse.GetCenterX, ellipse.GetCenterY, ellipse.GetRadiusX, ellipse.GetRadiusY);
        }
    }
}
