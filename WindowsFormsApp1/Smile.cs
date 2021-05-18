using System.Drawing;

namespace Shapes
{
    class Smile : Circle
    {
        public override void Draw()
        {
            if(Brush!=null)
            {
                Pen.Color = Color.Black;
            }
            //Brush = new SolidBrush(Color.Yellow);
            base.Draw();
            Brush = new SolidBrush(Color.White);
            DrawCircle(x1 - R/3, y1 - R / 3, R / 3);
            DrawCircle(x1 + R/3, y1 - R / 3, R / 3);
            Brush = new SolidBrush(Color.Green);
            DrawCircle(x1 - R / 3, y1 - R / 3, R / 6);
            DrawCircle(x1 + R / 3, y1 - R / 3, R / 6);
            Graphics graph = Graphics.FromImage(Bmp);
            graph.DrawArc(Pen, x1 - R / 3, y1 - R/256 , 4*R/6, R/2, 0, 180);
        }

    }
}
