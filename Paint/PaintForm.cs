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
using Rectangle = Paint.Classes.Figures.Rectangle;

namespace Paint
{
    public partial class PaintForm : System.Windows.Forms.Form
    {
        
        private CreatorShapes creatorShapes = new CreatorShapes();
        private MouseController mouseController = new MouseController();
        private Shape shapeToDraw;
        
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
            shapeToDraw = creatorShapes.CreatingShape(shapeToDraw, mouseController.GetPointMouseDown(),
                mouseController.GetPointMouseUp(), panelColor.BackColor);
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingShape(shapeToDraw);
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            shapeToDraw = creatorShapes.CreatingShape(new Line(), mouseController.GetPointMouseDown(), mouseController.GetPointMouseUp(), panelColor.BackColor);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            shapeToDraw = creatorShapes.CreatingShape(new Ellipse(), mouseController.GetPointMouseDown(), mouseController.GetPointMouseUp(), panelColor.BackColor);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            shapeToDraw = creatorShapes.CreatingShape(new Rectangle(), mouseController.GetPointMouseDown(), mouseController.GetPointMouseUp(), panelColor.BackColor);
        }

        private void buttonRhombus_Click(object sender, EventArgs e)
        {
            shapeToDraw = creatorShapes.CreatingShape(new Rhombus(), mouseController.GetPointMouseDown(), mouseController.GetPointMouseUp(), panelColor.BackColor);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            shapeToDraw = creatorShapes.CreatingShape(new Triangle(), mouseController.GetPointMouseDown(), mouseController.GetPointMouseUp(), panelColor.BackColor);
        }

        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons != MouseButtons.Left) return;
            shapeToDraw = creatorShapes.CreatingShape(shapeToDraw, mouseController.GetPointMouseDown(),
                mouseController.GetPointMouseUp(), panelColor.BackColor);
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingShape(shapeToDraw);
        }
    }
}
