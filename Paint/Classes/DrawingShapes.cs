using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Classes.Figures;

namespace Paint.Classes
{
    internal static class DrawingShapes
    {
        private static readonly Form DrawingForm = Form.ActiveForm;
        private static readonly Graphics FormGraphics = DrawingForm.CreateGraphics();

        public static void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color);
            FormGraphics.DrawEllipse(penColor, ellipse.GetCenterPointX, ellipse.GetCenterPointY, ellipse.GetRadiusX, ellipse.GetRadiusY);
        }

        public static void Draw(Rectangleq rectangle)
        {
            var penColor = new Pen(rectangle.Color);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY + rectangle.GetHeigth, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
        }
    }
}
