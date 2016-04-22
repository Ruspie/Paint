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
        private readonly Graphics _formGraphics;

        public DrawingShapes(Form form)
        {
            _formGraphics = form.CreateGraphics();
        }

        private void Draw(BigPoint bigPoint)
        {
            var pen = new Pen(bigPoint.Color, bigPoint.PenWidth);
            _formGraphics.DrawLine(pen, bigPoint.FirstPoint.X, bigPoint.FirstPoint.Y, bigPoint.FirstPoint.X, bigPoint.FirstPoint.Y+bigPoint.PenWidth);
        }
        private void Draw(Ellipse ellipse)
        {
            var penColor = new Pen(ellipse.Color, ellipse.PenWidth);
            _formGraphics.DrawEllipse(penColor, ellipse.FirstPoint.X, ellipse.FirstPoint.Y, ellipse.Width, ellipse.Heigth);
        }

        private void Draw(Rectangle rectangle)
        {
            var penColor = new Pen(rectangle.Color, rectangle.PenWidth);
            _formGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y);
            _formGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y,
                rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y + rectangle.Heigth);
            _formGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y + rectangle.Heigth);
            _formGraphics.DrawLine(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y + rectangle.Heigth,
                rectangle.TopLeftPoint.X + rectangle.Width, rectangle.TopLeftPoint.Y + rectangle.Heigth);
            //_formGraphics.DrawRectangle(penColor, rectangle.TopLeftPoint.X, rectangle.TopLeftPoint.Y, rectangle.Width, rectangle.Heigth);
        }

        private void Draw(Rhombus rhombus)
        {
            var penColor = new Pen(rhombus.Color, rhombus.PenWidth);
            _formGraphics.DrawLine(penColor, rhombus.FirstPoint, rhombus.SecondPoint);
            _formGraphics.DrawLine(penColor, rhombus.SecondPoint, rhombus.ThirdPoint);
            _formGraphics.DrawLine(penColor, rhombus.ThirdPoint, rhombus.FourthPoint);
            _formGraphics.DrawLine(penColor, rhombus.FourthPoint, rhombus.FirstPoint);
        }

        private void Draw(Line line)
        {
            var penColor = new Pen(line.Color, line.PenWidth);
            _formGraphics.DrawLine(penColor, line.FirstPoint, line.SecondPoint);
        }

        private void Draw(Triangle triangle)
        {
            var penColor = new Pen(triangle.Color, triangle.PenWidth);
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

        public void ClearField(Form form)
        {
            _formGraphics.Clear(form.BackColor);
        }
    }
}
