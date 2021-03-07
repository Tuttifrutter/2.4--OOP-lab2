using System.Drawing;
using System;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Collections.Generic;

namespace Shapes
{
    abstract public class Shape
    {
        public abstract void SetValue(List<int> arr);
        public virtual int Argcount { get; }
        public string Name { get; set; }
        public Bitmap Bmp { get; set; }
        public Pen Pen { get; set; }
        public abstract void Draw();
    }
}

