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
        private int NumberShape { get; set; }
        private Point ClickDownPoint { get; set; }
        private Point ClickUpPoint { get; set; }
        public PaintForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ellipse = new Ellipse(new Point(50, 50), 100, 100, Color.Blue);
            DrawingShapes.Draw(ellipse);
            var rectangle = new Rectangleq(new Point(50, 50), 50, 70, Color.Firebrick);
            DrawingShapes.Draw(rectangle);
            var line = new Line(new Point(50, 50), new Point(100, 100), Color.Black);
            DrawingShapes.Draw(line);
            var triangle = new Triangle(new Point(50, 50), new Point(125, 100), new Point(75, 145), Color.Coral);
            DrawingShapes.Draw(triangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberShape = 1;
        }

        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (NumberShape)
            {
                case 1:
                    ClickDownPoint = new Point(MousePosition.X - Form.ActiveForm.Location.X, MousePosition.Y - Form.ActiveForm.Location.Y);
                    break;
            }
        }

        private float GetRadius(Point firstPoint, Point secondPoint)
        {
            return (float)Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2));
        }
        private void PaintForm_MouseUp(object sender, MouseEventArgs e)
        {
            switch (NumberShape)
            {
                case 1:
                    ClickUpPoint = Cursor.Position;
                    //var ellipse = new Ellipse(new Point(50, 50), 100, 100, Color.Blue);
                    //DrawingShapes.Draw(ellipse);

                    var ellipse = new Ellipse(ClickDownPoint, GetRadius(ClickDownPoint, ClickUpPoint), GetRadius(ClickDownPoint, ClickUpPoint), Color.Blue);
                    DrawingShapes.Draw(ellipse);
                    break;
            }
        }
    }
}
