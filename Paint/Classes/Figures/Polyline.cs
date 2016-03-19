using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Classes.Figures
{
    internal class Polyline: Shape
    {
        public List<Line> Lines;

        public Polyline(List<Line> lines)
        {
            this.Lines = lines;
        }
    }
}
