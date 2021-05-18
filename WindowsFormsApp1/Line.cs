using System.Drawing;
using System.Collections.Generic;

namespace Shapes
{
    public class Line : Point
    {
        public override int Argcount { get; } = 4;
        public int x2, y2;
        public override void Draw()
        {
            DrawLine(x1, y1, x2, y2);
        }
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawLine(Pen, x1, y1, x2, y2);
        }
        public override void SetValue(List<int> arr)
        {
            base.SetValue(arr);
            x2 = arr[2];
            y2 = arr[3];
        }
    }
}
