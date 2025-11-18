using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai5
{
    public partial class Form1 : Form
    {
        private Point startPoint, endPoint;
        private bool isDrawing = false;

        private Color borderColor = Color.Blue;
        private Color fillColor = Color.Red;
        private float borderSize = 2f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShape.Items.AddRange(new string[]
            {
                "Line",
                "Rectangle",
                "Ellipse",
                "Filled Rectangle",
                "Filled Ellipse"
            });
            cboShape.SelectedIndex = 0;
        }

        private void lblFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog1.Color;
                lblFillColor.BackColor = fillColor;
            }
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            borderSize = (float)nudSize.Value;
        }

        private void lblBorderColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                borderColor = colorDialog1.Color;
                lblBorderColor.BackColor = borderColor;
            }
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                VeHinh(pnlDraw.CreateGraphics());
                isDrawing = false;
            }
        }

        private void VeHinh(Graphics g)
        {
            Pen pen = new Pen(borderColor, borderSize);
            Brush brush = new SolidBrush(fillColor);

            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int w = Math.Abs(startPoint.X - endPoint.X);
            int h = Math.Abs(startPoint.Y - endPoint.Y);

            string shape = cboShape.SelectedItem.ToString();

            switch (shape)
            {
                case "Line":
                    g.DrawLine(pen, startPoint, endPoint);
                    break;

                case "Rectangle":
                    g.DrawRectangle(pen, x, y, w, h);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, x, y, w, h);
                    break;

                case "Filled Rectangle":
                    g.FillRectangle(brush, x, y, w, h);
                    g.DrawRectangle(pen, x, y, w, h);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, x, y, w, h);
                    g.DrawEllipse(pen, x, y, w, h);
                    break;
            }

            pen.Dispose();
            brush.Dispose();
        }
    }
}
