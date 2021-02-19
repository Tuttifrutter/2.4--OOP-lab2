using System.Drawing;
using System; 
using System.Windows.Forms;

namespace Shapes
{
    class Circle : Shape 
    {
        public override Shape DrawShape(ref Bitmap bmp, int[] arr)
        {
            Pen pen = GetPenColor();
            pen.Width = PenWidth;
            Graphics graph = Graphics.FromImage(bmp);
            graph.DrawEllipse(pen, arr[0], arr[1], (arr[2] + arr[3]) / 2, (arr[2] + arr[3]) / 2);
            return new Circle();
        }
    }
}
