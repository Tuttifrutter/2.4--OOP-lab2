using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shapes
{
    class Quadrate : Line 
    {
        public override int Argcount { get; } = 4;

        public int a;
        public override void Draw()
        {
            DrawQuadrate(x1, y1, a);
        }
        public void DrawQuadrate(int x1, int y1, int a)
        {
            base.DrawLine(x1, y1, x1 + a + Convert.ToInt32(Pen.Width), y1);
            base.DrawLine(x1, y1, x1, y1 + a + Convert.ToInt32(Pen.Width));
            base.DrawLine(x1 + a + Convert.ToInt32(Pen.Width), y1 + a + Convert.ToInt32(Pen.Width), x1 + a + Convert.ToInt32(Pen.Width), y1);
            base.DrawLine(x1 + a + Convert.ToInt32(Pen.Width), y1 + a + Convert.ToInt32(Pen.Width), x1, y1 + a + Convert.ToInt32(Pen.Width));
        }
        public override void SetValue(List<int> arr)
        {
            x1 = arr[0];
            y1 = arr[1];
            if (Math.Abs(arr[3] - arr[1]) > Math.Abs(arr[2] - arr[0]))
            {
                a = Math.Abs(arr[3] - arr[1]);
            }
            else
            {
                a = Math.Abs(arr[2] - arr[0]);
            }  
        }
    }
}
