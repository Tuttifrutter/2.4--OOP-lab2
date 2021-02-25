using System.Drawing;
using System;
using System.Windows.Forms;

namespace Shapes
{
    public class Triangle : Shape
    {
        public override int Dropcount { get; } = 3;
        public override void Draw(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            Point[] PointARR = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
            graph.DrawPolygon(Pen, PointARR);
        }
    }
}
