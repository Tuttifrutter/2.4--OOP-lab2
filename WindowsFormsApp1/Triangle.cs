using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shapes
{
    public class Triangle : Line
    {
        public override int Argcount { get; } = 6;
        public int x3, y3;
        public override void Draw()
        {
            DrawTriangle(x1, y1, x2, y2, x3, y3);
        }
        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            DrawLine(x1, y1, x2, y2);
            DrawLine(x1, y1, x3, y3);
            DrawLine(x2, y2, x3, y3);
        }

        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
            x3 = arr[4];
            y3 = arr[5];
        }
    }
}

