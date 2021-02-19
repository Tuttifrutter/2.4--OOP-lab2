using System.Drawing;
using System;
using System.Windows.Forms;
namespace Shapes
{
    class Rectangle : Shape 
    {
        public override Shape DrawShape(ref Bitmap bmp, int[] arr)
        {
            Pen pen = GetPenColor();
            pen.Width = PenWidth;
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawRectangle(pen, arr[0], arr[1], arr[2], arr[3]);
            return new Rectangle();
        }
    }
}
