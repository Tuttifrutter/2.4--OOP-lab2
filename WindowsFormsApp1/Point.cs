using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
    public class Point : Shape
    {
        public int x1, y1;
        public override int Argcount { get; } = 2;
        public override void Draw()
        {
            DrawDrop(x1, y1);
        }
        public void DrawDrop(int x1, int y1)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawLine(Pen, x1, y1, x1 + Pen.Width, y1);
        }
        public override void SetValue(List<int> arr)
        {
            x1 = arr[0];
            y1 = arr[1];
        }
    }
}

