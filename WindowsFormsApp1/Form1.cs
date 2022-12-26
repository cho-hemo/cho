using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect = new Rectangle(50, 50, 100, 100);
            Pen pen = new Pen(Color.Red, 10);
            graphics.DrawRectangle(pen, rect);
            Brush brush = new SolidBrush(Color.DarkCyan);
            graphics.FillRectangle(brush, rect);
            Font font = new Font("고딕", 12);
            graphics.DrawString("50,50", font, Brushes.Black, new PointF(25, 25));
            graphics.DrawString("150,150", font, Brushes.Black, new PointF(125, 163));
        }


    }
}
