using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Classes;
using Paint.Classes.Figures;

namespace Paint
{
    public partial class PaintForm : System.Windows.Forms.Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            var ellipse = new Ellipse(new Point(300, 100), 150, 100, Color.Blue);            
            var rectangle = new Rectangleq(new Point(550, 320), 120, 50, Color.Firebrick);          
            var line = new Line(new Point(650, 50), new Point(70, 500), Color.Black);
            var triangle = new Triangle(new Point(1000, 500), new Point(900, 200), new Point(750, 300), Color.Coral);
            var pointsLine = new List<Line>()
            {
                new Line(new Point(100, 100), new Point(150, 150), Color.ForestGreen),
                new Line(new Point(150, 150), new Point(180, 230), Color.ForestGreen),
                new Line(new Point(180, 230), new Point(50, 120), Color.ForestGreen),
                new Line(new Point(50, 120), new Point(40, 90), Color.ForestGreen)
            };

            var polyline = new Polyline(pointsLine);

            var listShape = new List<Shape>()
            {
                ellipse,
                rectangle,
                triangle,
                line,
                polyline
            };

            DrawingListShape(listShape);
        }

        private void DrawingListShape(List<Shape> listShape)
        {
            foreach (var shape in listShape)
            {
                dynamic shapeToDraw = shape;
                DrawingShapes.Draw(shapeToDraw);
            }
        }
    }
}
