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
        
        private CreatorShapes creatorShapes = new CreatorShapes();
        private MouseController mouseController = new MouseController();
        private Shape shapeToDraw;
        private Shapes shapes;

        private enum Shapes
        {
            Ellipse,
            Line,
            Rectangle,
            Rhombus,
            Triangle
        };
        
        public PaintForm()
        {
            InitializeComponent();
        }
        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseController.SetPointMouseDown(e);
        }

        private void PaintForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseController.SetPointMouseUp(e);
            switch (shapes)
            {
                case Shapes.Line:
                {
                    shapeToDraw = creatorShapes.CreateLine(mouseController.GetPointMouseDown(),
                        mouseController.GetPointMouseUp(), panelColor.BackColor);
                    break;
                }
                    case Shapes.Ellipse:
                {
                    shapeToDraw = creatorShapes.CreateEllipse(mouseController.GetPointMouseDown(),
                        mouseController.GetPointMouseUp(), panelColor.BackColor);
                    break;
                }
                    case Shapes.Rectangle:
                {
                    shapeToDraw = creatorShapes.CreateRectangle(mouseController.GetPointMouseDown(),
                        mouseController.GetPointMouseUp(), panelColor.BackColor);
                    break;
                }
                    case Shapes.Rhombus:
                {
                    shapeToDraw = creatorShapes.CreateRhombus(mouseController.GetPointMouseDown(),
                        mouseController.GetPointMouseUp(), panelColor.BackColor);
                    break;
                }
                    case Shapes.Triangle:
                {
                    shapeToDraw = creatorShapes.CreateTriangle(mouseController.GetPointMouseDown(),
                        mouseController.GetPointMouseUp(), panelColor.BackColor);
                    break;
                }
                  
            }
            //shapeToDraw = new Line(new Point(250,250), new Point(500,500), panelColor.BackColor );
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingShape(shapeToDraw);
        }


        private void panelColor_Click(object sender, EventArgs e)
        {
            creatorShapes.SetColor(panelColor);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            shapes = Shapes.Line;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            shapes = Shapes.Ellipse;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            shapes = Shapes.Rectangle;
        }

        private void buttonRhombus_Click(object sender, EventArgs e)
        {
            shapes = Shapes.Rhombus;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            shapes = Shapes.Triangle;
        }
    }
}
