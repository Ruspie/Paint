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
        public const int PenWidth = 2;
        private static readonly Form DrawingForm = Form.ActiveForm;
        private static readonly Graphics FormGraphics = DrawingForm.CreateGraphics();

        public static void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color, PenWidth);
            FormGraphics.DrawEllipse(penColor, ellipse.GetCenterPointX, ellipse.GetCenterPointY, ellipse.GetRadiusX, ellipse.GetRadiusY);
        }

        public static void Draw(Rectangleq rectangle)
        {
            var penColor = new Pen(rectangle.Color, PenWidth);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
            FormGraphics.DrawLine(penColor, rectangle.GetTopLeftPointX, rectangle.GetTopLeftPointY + rectangle.GetHeigth, rectangle.GetTopLeftPointX + rectangle.GetWidth, rectangle.GetTopLeftPointY + rectangle.GetHeigth);
        }

        public static void Draw(Line line)
        {
            var penColor = new Pen(line.Color, PenWidth);
            FormGraphics.DrawLine(penColor, line.GetFirstPoint, line.GetSecondPoint);
        }

        public static void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color, PenWidth);
            FormGraphics.DrawLine(penColor, triangle.GetFirstPoint, triangle.GetSecondPoint);
            FormGraphics.DrawLine(penColor, triangle.GetSecondPoint, triangle.GetThirdPoint);
            FormGraphics.DrawLine(penColor, triangle.GetFirstPoint, triangle.GetThirdPoint);
        }
    }
}
