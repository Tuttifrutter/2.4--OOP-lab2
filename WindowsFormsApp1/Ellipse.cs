using System.Drawing;

namespace Shapes
{
    class Ellipse : Shape
    {
        public override int Dropcount { get; } = 2;
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawEllipse(Pen, x1, y1, x2, y2);
        }
    }
}
