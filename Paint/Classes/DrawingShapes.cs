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
    internal class DrawingShapes
    {
        private const int PenWidth = 2;
        private readonly Graphics FormGraphics;
        
        public DrawingShapes(Form formGraphics)
        {
            FormGraphics = formGraphics.CreateGraphics();
        }
        public void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color, PenWidth);
            FormGraphics.DrawEllipse(penColor, ellipse.CenterPoint.X, ellipse.CenterPoint.Y, ellipse.RadiusX, ellipse.RadiusY);
        }

        public void Draw(Figures.Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color, PenWidth);
            FormGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y, 
                rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y + rectangle.Heigth);
            FormGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y);
            FormGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y + rectangle.Heigth);
            FormGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y + rectangle.Heigth,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y + rectangle.Heigth);
        }

        public void Draw(Line line)
        {
            var penColor = new Pen(line.Color, PenWidth);
            FormGraphics.DrawLine(penColor, line.FirstPoint, line.SecondPoint);
        }

        public void Draw(Polyline polyline)
        {
            foreach (var line in polyline.Lines)
            {
                var penColor = new Pen(line.Color, PenWidth);
                FormGraphics.DrawLine(penColor, line.FirstPoint, line.SecondPoint);
            }
        }

        public void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color, PenWidth);
            FormGraphics.DrawLine(penColor, triangle.FirstPoint, triangle.SecondPoint);
            FormGraphics.DrawLine(penColor, triangle.SecondPoint, triangle.ThirdPoint);
            FormGraphics.DrawLine(penColor, triangle.FirstPoint, triangle.ThirdPoint);
        }

        public void DrawingListShape(List<Shape> listShape)
        {
            foreach (var shape in listShape)
            {
                dynamic shapeToDraw = shape;
                Draw(shapeToDraw);
            }
        }
    }
}
