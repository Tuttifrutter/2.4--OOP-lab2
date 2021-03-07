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
        public Shape mainShape = new Circle();
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
            mainShape = new Circle();
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            mainShape = new Line();
        }

        private void QuadrateBtn_Click(object sender, EventArgs e)
        {
            mainShape = new Quadrate();
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            mainShape = new Triangle();
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            mainShape = new Ellipse();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            mainShape = new Rectangle();
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
                button7.BackColor = MyDialog.Color;
                PenColor = MyDialog.Color.Name;
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   
                if (mainShape.Argcount==drops.Count)
                { 
                    mainShape.Bmp = bmp;
                    mainShape.SetValue(drops);
                    mainShape.Pen = SetPenValue(PenColor, PenWidth);
                    mainShape.Draw();
                   
                    pictureBox1.Image = mainShape.Bmp;
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

        private void BtnArc_Click(object sender, EventArgs e)
        {
            mainShape = new Arc();
        }
    }
}


