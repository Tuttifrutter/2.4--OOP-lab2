using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shapes
{
    class Rectangle : Line 
    {
        public override int Argcount { get; } = 4;

        public override void Draw()
        {
            DrawRectangle(x1, y1, x2, y2);
        }
        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            DrawLine(x1, y1, x1, y2);
            DrawLine(x1, y2, x2, y2);
            DrawLine(x2, y2, x2, y1);
            DrawLine(x2, y1, x1, y1);
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
        }
    }
}
