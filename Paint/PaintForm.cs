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

        private void button1_Click(object sender, EventArgs e)
        {
            var ellipse = new Ellipse(new Point(50, 50), 100, 100, Color.Blue);
            DrawingShapes.Draw(ellipse);
            var rectangle = new Rectangleq(new Point(50, 50), 50, 70, Color.Firebrick);
            DrawingShapes.Draw(rectangle);
        }
    }
}
