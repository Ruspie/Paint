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
        private Line Create(Line line, Point pointA, Point pointB, Color color)
        {
            return new Line(pointA, pointB, color);
        }

        private Ellipse Create(Ellipse ellipse, Point pointA, Point pointB, Color color)
        {
            return new Ellipse(pointA, pointB.X - pointA.X, pointB.Y - pointA.Y, color);
        }

        private Rectangle Create(Rectangle rectangle,Point pointA, Point pointB, Color color)
        {
            return new Rectangle(pointA, pointB.X - pointA.X, pointB.Y - pointA.Y, color);
        }

        private Rhombus Create(Rhombus rhombus, Point topLeftPoint, Point bottomRighеPoint, Color color)
        {
            var listPoint = GetPointsToRhombus(topLeftPoint, bottomRighеPoint);
            return new Rhombus(listPoint[0], listPoint[1], listPoint[2], listPoint[3], color);
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

        private Triangle Create(Triangle triangle, Point topLeftPoint, Point bottomRightPoint, Color color)
        {
            var listPoint = GetPointsToTriangle(topLeftPoint, bottomRightPoint);
            return new Triangle(listPoint[0], listPoint[1], listPoint[2], color);
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

        public Shape CreatingShape(Shape shape, Point topLeftPoint, Point bottomRightPoint, Color color)
        {
            dynamic shapeToCreate = shape;
            return Create(shapeToCreate, topLeftPoint, bottomRightPoint, color);
        }
    }
}
