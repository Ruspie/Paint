using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Classes.Figures;
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint.Classes
{
    internal class DrawingShapes
    {
        private const int PenWidth = 2;
        private readonly Graphics _formGraphics;

        public DrawingShapes(Form formGraphics)
        {
            _formGraphics = formGraphics.CreateGraphics();
        }
        private void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color, PenWidth);
            _formGraphics.DrawEllipse(penColor, ellipse.TopLeftPoint.X, ellipse.TopLeftPoint.Y, ellipse.Width, ellipse.Heigth);
        }

        private void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color, PenWidth);
            _formGraphics.DrawRectangle(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y, rectangle.Width, rectangle.Heigth);
        }

        private void Draw(Rhombus rhombus)
        {
            var penColor = new Pen(rhombus.Color, PenWidth);
            _formGraphics.DrawLine(penColor, rhombus.FirstPoint, rhombus.SecondPoint);
            _formGraphics.DrawLine(penColor, rhombus.SecondPoint, rhombus.ThirdPoint);
            _formGraphics.DrawLine(penColor, rhombus.ThirdPoint, rhombus.FourthPoint);
            _formGraphics.DrawLine(penColor, rhombus.FourthPoint, rhombus.FirstPoint);
        }

        private void Draw(Line line)
        {
            var penColor = new Pen(line.Color, PenWidth);
            _formGraphics.DrawLine(penColor, line.FirstPoint, line.SecondPoint);
        }

        private void Draw(Polyline polyline)
        {
            foreach (var line in polyline.Lines)
            {
                var penColor = new Pen(line.Color, PenWidth);
                _formGraphics.DrawLine(penColor, line.FirstPoint, line.SecondPoint);
            }
        }

        private void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color, PenWidth);
            _formGraphics.DrawLine(penColor, triangle.FirstPoint, triangle.SecondPoint);
            _formGraphics.DrawLine(penColor, triangle.SecondPoint, triangle.ThirdPoint);
            _formGraphics.DrawLine(penColor, triangle.ThirdPoint, triangle.FirstPoint);
        }

        public void DrawingListShape(List<Shape> listShape)
        {
            foreach (var shape in listShape)
            {
                dynamic shapeToDraw = shape;
                Draw(shapeToDraw);
            }
        }

        public void DrawingShape(Shape shape)
        {
            dynamic shapeToDraw = shape;
            Draw(shapeToDraw);
        }
    }
}
