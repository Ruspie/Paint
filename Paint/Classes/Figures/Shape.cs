using System.Drawing;

namespace Paint.Classes.Figures
{
    internal abstract class Shape
    {
        public Color  Color { get; protected set;}
        public int PenWidth { get; protected set; }
    }
}
