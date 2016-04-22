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
        private readonly ListDrowedShapes _listDrowedShapes = new ListDrowedShapes();
        private readonly CreatorShapes _creatorShapes = new CreatorShapes();
        private readonly MouseController _mouseController = new MouseController();
        private Shape _shapeToDraw = new Line();
        
        public PaintForm()
        {
            InitializeComponent();
        }
        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseController.PointMouseDown = e.Location;
        }

        private void PaintForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseController.PointMouseUp= e.Location;
            _shapeToDraw = _creatorShapes.CreatingShape(_shapeToDraw, _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingShape(_shapeToDraw);
            _listDrowedShapes.ShapesList.Add(_shapeToDraw);
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
            _shapeToDraw = _creatorShapes.CreatingShape(new Line(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            _shapeToDraw = _creatorShapes.CreatingShape(new BigPoint(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            _shapeToDraw = _creatorShapes.CreatingShape(new Ellipse(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _shapeToDraw = _creatorShapes.CreatingShape(new Rectangle(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void buttonRhombus_Click(object sender, EventArgs e)
        {
            _shapeToDraw = _creatorShapes.CreatingShape(new Rhombus(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            _shapeToDraw = _creatorShapes.CreatingShape(new Triangle(), _mouseController.PointMouseDown,
                _mouseController.PointMouseUp, panelColor.BackColor, int.Parse(labelSize.Text));
        }

        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseController.IsCLick)
            {
                var drawingShapes = new DrawingShapes(Form.ActiveForm);
                _shapeToDraw = _creatorShapes.CreatingShape(_shapeToDraw, _mouseController.PointMouseDown,
                    _mouseController.PointMouseLast, this.BackColor, int.Parse(labelSize.Text));
                drawingShapes.DrawingShape(_shapeToDraw);

                _shapeToDraw = _creatorShapes.CreatingShape(_shapeToDraw, _mouseController.PointMouseDown,
                    e.Location, panelColor.BackColor, int.Parse(labelSize.Text));
                drawingShapes.DrawingShape(_shapeToDraw);

                _mouseController.PointMouseLast = e.Location;
                drawingShapes.DrawingListShape(_listDrowedShapes.ShapesList);
            }
            else
            {
                _mouseController.PointMouseLast = e.Location;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _listDrowedShapes.ShapesList.Clear();
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.ClearField(Form.ActiveForm); 
           
        }

        private void buttonSizeUp_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelSize.Text) < 10)
                labelSize.Text = (int.Parse(labelSize.Text) + 1).ToString();
        }

        private void buttonSizeDown_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelSize.Text) > 1)
                labelSize.Text = (int.Parse(labelSize.Text) - 1).ToString();
        }

        private void PaintForm_Move(object sender, EventArgs e)
        {
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingListShape(_listDrowedShapes.ShapesList);
        }

        private void PaintForm_ClientSizeChanged(object sender, EventArgs e)
        {
            var drawingShapes = new DrawingShapes(Form.ActiveForm);
            drawingShapes.DrawingListShape(_listDrowedShapes.ShapesList);
        }
    }
}