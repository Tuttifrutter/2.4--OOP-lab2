using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
    class Ellipse : Circle
    {
        public override int Argcount { get; } = 4;
        public int R2;
        public override void Draw()
        {
            DrawEllipse(x1, y1, R, R2);
        }
        public void DrawEllipse(int x1, int y1, int R, int R2)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            if (Brush != null)
                graph.FillEllipse(Brush,x1,y1, R, R2);
            graph.DrawEllipse(Pen, x1, y1, R, R2);
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
            R = Math.Abs(arr[2] - arr[0]);
            R2 = Math.Abs(arr[3] - arr[1]);
        }
    }
}
