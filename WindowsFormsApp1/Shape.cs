using System.Drawing;
using System;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Shapes
{
    abstract public class Shape
    {
        public Bitmap Bmp { get; set; }
        public Pen Pen { get; set; }
        public virtual int Dropcount{ get; } = 1;
        public virtual void Draw(int x1, int y1){}
        public virtual void Draw(int x1, int y1, int x2, int y2){}
        public virtual void Draw(int x1, int y1, int x2, int y2, int x3, int y3){}
    }
}

