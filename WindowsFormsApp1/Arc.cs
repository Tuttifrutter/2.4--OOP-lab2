using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
    class Arc:Triangle
    {
        public override int Argcount { get; } = 6;
        public override void Draw()
        {
            DrawArc(x1,y1,x2,y2,x3,y3);
        }
        
        public void DrawArc(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int R1 = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            int R2 = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)));
            int c = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));
            int x4 = x2 - R1;
            int y4 = y2;
            int c0 = Convert.ToInt32(Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)));
            double startAngle = Math.Acos((Math.Pow(R1, 2) + Math.Pow(R1, 2) - Math.Pow(c0, 2)) / (2 * R1 * R1));
            float start = ((float)(startAngle / Math.PI) * 180+180)%360;
            double sweepAngle = Math.Acos((Math.Pow(R1, 2) + Math.Pow(R2, 2) - Math.Pow(c, 2)) / (2*R1*R2));
            float sweep = (float)(sweepAngle / Math.PI) * 180;
            Graphics graph = Graphics.FromImage(Bmp);
            double h = R1 * 2 * Math.Sin(sweepAngle);
            x1 = Math.Min(Math.Min(x1,x3),x2);
            R1 = Math.Max(R1, R2);
            graph.DrawArc(Pen, x1, y2-R1, c, (float)h, start, sweep);
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
        }
    }
}
