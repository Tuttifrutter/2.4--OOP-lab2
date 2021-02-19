using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using Shapes;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PenColor = "Black";
        }
        static readonly int PictureBoxWidth = 634;
        static readonly int PictureBoxHeight = 355;
        Bitmap bmp = new Bitmap(PictureBoxWidth, PictureBoxHeight);
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Circle";
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Line";
        }

        private void QuadrateBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Quadrate";
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Triangle";
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Ellipse";
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            Tag = "Shapes.Rectangle";
        }

        int  iMouseX, iMouseY,PenWidth;
        string PenColor;
        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = true,
                ShowHelp = true
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                PenColor = MyDialog.Color.Name;
                button7.Text = MyDialog.Color.Name;
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int iMouseX2 = e.Location.X;
            int iMouseY2 = e.Location.Y;
            if (e.Button == MouseButtons.Left)
            {
                int[] arr1 = { iMouseX, iMouseY, iMouseX2 - iMouseX, iMouseY2 - iMouseY };
                if (Tag == null)
                    Tag = "Shapes.Circle";
                Shape shape = (Shape)Activator.CreateInstance(Type.GetType((string)Tag));
                shape.PenWidth = PenWidth;
                shape.PenColor = PenColor;
                Shape _ = shape.DrawShape(ref bmp, arr1);
                pictureBox1.Image = bmp;
            }
        }
           
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            bool b =Int32.TryParse(textBox1.Text, out int x);
            if (b==true && x>=1 && x<=100)
            {
                PenWidth = x;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            iMouseX = e.Location.X;
            iMouseY = e.Location.Y;
        }
    }
}


