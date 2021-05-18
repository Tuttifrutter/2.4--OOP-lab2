using System.Drawing;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Circle : Point 
    {
        public override int Argcount { get; } = 4;
        public int R;
        public override void Draw()
        {
            DrawCircle(x1, y1, R);
        }
        public void DrawCircle(int x1, int y1, int R)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            if (Brush != null) 
            graph.FillEllipse(Brush, Math.Abs(x1 - R), Math.Abs(y1 - R), R * 2, R * 2);
            graph.DrawEllipse(Pen, Math.Abs(x1 - R), Math.Abs(y1 - R), R * 2, R * 2);
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
            R = Convert.ToInt32(Math.Sqrt(Math.Pow(arr[2]-arr[0], 2) + Math.Pow(arr[3]-arr[1], 2)));
        }
    }
}
