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

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);

            g.DrawLine(p, new Point(20,20),new Point(300, 20));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            PointF[] pointFs = { new PointF(50,50), new PointF(20,100), new PointF(100,100) };

            g.DrawPolygon(p, pointFs);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Pen p = new Pen(Color.Red, 2);

            g.DrawRectangle(p, new Rectangle(20, 120, 200, 100));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
