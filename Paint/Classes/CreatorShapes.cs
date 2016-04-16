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
    class CreatorShapes
    {
        //public Point CreatePoint(Point _point, Color color)
        //{
        //    var point = new Point(_point.X, _point.Y) {Color = color};
        //    return point;
        //}

        public Line CreateLine(Point pointA, Point pointB, Color color)
        {
            var line = new Line(pointA, pointB, color);
            return line;
        }

        public Ellipse CreateEllipse(Point pointA, Point pointB, Color color)
        {
            var ellipse = new Ellipse(pointA, pointB.X - pointA.X, pointB.Y - pointA.Y, color);
            return ellipse;
        }

        public Rectangle CreateRectangle(Point pointA, Point pointB, Color color)
        {
            var rectangle = new Rectangle(pointA, pointB.X - pointA.X, pointB.Y - pointA.Y, color);
            return rectangle;
        }

        public Rhombus CreateRhombus(Point topLeftPoint, Point bottomRighеPoint, Color color)
        {
            var listPoint = GetPointsToRhombus(topLeftPoint, bottomRighеPoint);
            var rhombus = new Rhombus(listPoint[0], listPoint[1],listPoint[2], listPoint[3], color);
            return rhombus;
        }

        private List<Point> GetPointsToRhombus(Point topLeftPoint, Point bottomRightPoint)
        {
            var firstPoint = new Point((topLeftPoint.X + bottomRightPoint.X)/2, topLeftPoint.Y);
            var secondPoint = new Point(topLeftPoint.X, (topLeftPoint.Y + bottomRightPoint.Y)/2);
            var thirdPoint = new Point((topLeftPoint.X + bottomRightPoint.X)/2, bottomRightPoint.Y);
            var fourthPoint = new Point(bottomRightPoint.X, (topLeftPoint.Y + bottomRightPoint.Y)/2);
            var listPoint = new List<Point>()
            {
                firstPoint, secondPoint, thirdPoint, fourthPoint
            };
            return listPoint;
        }

        public Triangle CreateTriangle(Point topLeftPoint, Point bottomRightPoint, Color color)
        {
            var listPoint = GetPointsToTriangle(topLeftPoint, bottomRightPoint);
            var triangle = new Triangle(listPoint[0], listPoint[1], listPoint[2], color);
            return triangle;
        }

        private List<Point> GetPointsToTriangle(Point topLeftPoint, Point bottomRightPoint)
        {
            var firstPoint = new Point((topLeftPoint.X + bottomRightPoint.X)/2, topLeftPoint.Y);
            var secondPoint = new Point(topLeftPoint.X, bottomRightPoint.Y);
            var thirdPoint = new Point(bottomRightPoint.X, bottomRightPoint.Y);

            var listPoint = new List<Point>()
            {
                firstPoint, secondPoint, thirdPoint
            };
            return listPoint;
        }

        public void SetColor(Panel panelColor)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
            }
        }

        public void CreatingShape(Shape shape)
        {
            dynamic ShapeToCreate = shape;
            shape = Create(ShapeToCreate);
        }
    }
}
