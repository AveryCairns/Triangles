using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen;

        public void DrawTriangle(Pen pen, int x1, int x2, int x3, int y1, int y2, int y3)
        {
            Graphics triGFX = this.CreateGraphics();
            triGFX.DrawLine(pen, x1, y1, x2, y2);
            triGFX.DrawLine(pen, x2, y2, x3, y3);
            triGFX.DrawLine(pen, x3, y3, x1, y1);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);
            DrawTriangle(pen, 50, 50, 100, 100, 75, 150);
        }
    }
}
