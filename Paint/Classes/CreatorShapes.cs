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
        private Line Create(Line line, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            return new Line(firstPoint, secondPoint, color, penWidth);
        }

        private BigPoint Create(BigPoint bigPoint, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            return new BigPoint(firstPoint, secondPoint, color, penWidth);
        }

        private Ellipse Create(Ellipse ellipse, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            return new Ellipse(firstPoint, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y, color, penWidth);
        }

        private Rectangle Create(Rectangle rectangle, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            return new Rectangle(firstPoint, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y, color, penWidth);
        }

        private Rhombus Create(Rhombus rhombus, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            var listPoint = GetPointsToRhombus(firstPoint, secondPoint);
            return new Rhombus(listPoint[0], listPoint[1], listPoint[2], listPoint[3], color, penWidth);
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

        private Triangle Create(Triangle triangle, Point firstPoint, Point secondPoint, Color color, int penWidth)
        {
            var listPoint = GetPointsToTriangle(firstPoint, secondPoint);
            return new Triangle(listPoint[0], listPoint[1], listPoint[2], color, penWidth);
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

        public Shape CreatingShape(Shape shape, Point topLeftPoint, Point bottomRightPoint, Color color, int penWidth)
        {
            dynamic shapeToCreate = shape;
            return Create(shapeToCreate, topLeftPoint, bottomRightPoint, color, penWidth);
        }
    }
}
