using System.Drawing;
using System;
using System.Windows.Forms;
namespace Shapes
{
    class Rectangle : Shape 
    {
        public override int Dropcount { get; } = 2;
        public override void Draw(int x1, int y1, int x2, int y2)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawRectangle(Pen, x1, y1, x2, y2);
        }
    }
}
