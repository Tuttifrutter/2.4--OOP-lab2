using System.Drawing;
using System;
namespace Shapes
{
    abstract class Shape
    {
        public abstract Shape DrawShape(ref Bitmap bmp, int[] arr);
        public int PenWidth;
        public string PenColor;

        public Pen GetPenColor()
        {
            Pen pen = new Pen(Color.Black, PenWidth);
            try
            {
                pen.Color = Color.FromArgb(Convert.ToInt32(PenColor, 16));
            }
            catch (FormatException)
            {
                pen.Color = Color.FromName(PenColor);
            }
            catch
            {
                pen.Color = Color.FromArgb(Convert.ToInt32(PenColor, 16));
            }
            return pen;
        }
    }
}

