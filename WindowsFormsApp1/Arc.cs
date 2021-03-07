using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
    class Arc:Triangle
    {
        public override int Argcount { get; } = 6;
        public override void Draw()
        {
            DrawArc(x1, y1, x2, y2, x3, y3);
        }
        public void DrawArc(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            if (y2 > y1)
            {
                graph.DrawArc(Pen, Math.Abs(x1), Math.Abs(y1), Math.Abs(x3 - x1), Math.Abs(y2 - y1), 0, 180);
            }
            else if (y2 < y1 && Math.Abs(y2 - y1) > Math.Abs(x2 - x1))
            {
                graph.DrawArc(Pen, Math.Abs(x1), Math.Abs(y1), Math.Abs(x3 - x1), Math.Abs(y2 - y1), 180, 180);
            }
            else if (x2 > x1 && Math.Abs(y2 - y1) > Math.Abs(x2 - x1))
            {
                graph.DrawArc(Pen, Math.Abs(x1), Math.Abs(y1), Math.Abs(y3 - y1), Math.Abs(x2 - x1), 90, 180);
            }
            else if (x1 > x2 && Math.Abs(y2 - y1) > Math.Abs(x2 - x1))
            {
                graph.DrawArc(Pen, Math.Abs(x1), Math.Abs(y1), Math.Abs(y3 - y1), Math.Abs(x2 - x1), 270, 180);
            }
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
        }
    }
}
