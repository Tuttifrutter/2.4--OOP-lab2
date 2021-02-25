using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using Shapes;
    using System.Collections.Generic;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PenColor = "Black";
        }
        static readonly int PictureBoxWidth = 634;
        static readonly int PictureBoxHeight = 355;
        readonly Bitmap bmp = new Bitmap(PictureBoxWidth, PictureBoxHeight);
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

        int  PenWidth;
        List<int> drops = new List<int>();
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
            if (e.Button == MouseButtons.Left)
            {   
                if (Tag == null)
                    Tag = "Shapes.Circle";
                Shape shape = (Shape)Activator.CreateInstance(Type.GetType((string)Tag));
                if (shape.Dropcount*2==drops.Count)
                { 
                   
                    shape.Bmp = bmp;
                    shape.Pen = SetPenValue(PenColor, PenWidth);
                    shape.Draw(drops[0], drops[1]);
                    if (shape.Dropcount == 2) 
                    {
                        shape.Draw(drops[0], drops[1], drops[2], drops[3]);
                    }
                    else
                    {
                        shape.Draw(drops[0], drops[1], drops[2], drops[3], drops[4], drops[5]);
                    }
                    pictureBox1.Image = shape.Bmp;
                    drops.Clear();
                }
                    
            }
        }
        
        private Pen SetPenValue(string PC, float PW)
        {
            Pen pen = new Pen(Color.Black, PW);
            try
            {
                pen.Color = Color.FromArgb(Convert.ToInt32(PC, 16));
            }
            catch (FormatException)
            {
                pen.Color = Color.FromName(PC);
            }
            catch
            {
                pen.Color = Color.FromArgb(Convert.ToInt32(PC, 16));
            }
            return pen;
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
            drops.Add(e.Location.X);
            drops.Add(e.Location.Y);
        }
    }
}


