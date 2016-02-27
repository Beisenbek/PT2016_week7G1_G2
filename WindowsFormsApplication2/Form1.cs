using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<PointF> arr = new List<PointF>();

        Pen pen = new Pen(Color.Red);

        public Form1()
        {
            InitializeComponent();

            for(int x = -5; x<=5; ++x)
            {
                int y = x * x;
                int px = x * 10 + 100;
                int py = -y* 10 + 200;
                arr.Add(new PointF(px, py ));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawWithCurve(e);
        }

        private void DrawWithCurve(PaintEventArgs e)
        {
            e.Graphics.DrawCurve(pen, arr.ToArray());
        }

        private void DrawWithEllipse(PaintEventArgs e)
        {
            foreach (PointF p in arr)
            {
                e.Graphics.DrawEllipse(pen, p.X, p.Y, 3, 3);
            }
        }
    }
}
