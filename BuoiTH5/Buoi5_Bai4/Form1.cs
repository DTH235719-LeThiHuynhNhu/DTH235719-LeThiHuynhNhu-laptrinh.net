using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Khi mở form, ẩn hết groupBox
            grpCircle.Visible = false;
            grpSquare.Visible = false;
            grpRectangle.Visible = false;
            grpTriangle.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grpCircle.Visible = rbCircle.Checked;
            grpSquare.Visible = false;
            grpRectangle.Visible = false;
            grpTriangle.Visible = false;
        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            grpSquare.Visible = rbSquare.Checked;
            grpCircle.Visible = false;
            grpRectangle.Visible = false;
            grpTriangle.Visible = false;
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            grpRectangle.Visible = rbRectangle.Checked;
            grpCircle.Visible = false;
            grpSquare.Visible = false;
            grpTriangle.Visible = false;
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            grpTriangle.Visible = rbTriangle.Checked;
            grpCircle.Visible = false;
            grpSquare.Visible = false;
            grpRectangle.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCircle.Checked)
                {
                    double r = double.Parse(txtCircleR.Text);
                    txtCirclePerim.Text = (2 * Math.PI * r).ToString("0.00");
                    txtCircleArea.Text = (Math.PI * r * r).ToString("0.00");
                }
                else if (rbSquare.Checked)
                {
                    double a = double.Parse(txtSquareA.Text);
                    txtSquarePerim.Text = (4 * a).ToString();
                    txtSquareArea.Text = (a * a).ToString();
                }
                else if (rbRectangle.Checked)
                {
                    double w = double.Parse(txtRectW.Text);
                    double h = double.Parse(txtRectH.Text);
                    txtRectPerim.Text = (2 * (w + h)).ToString();
                    txtRectArea.Text = (w * h).ToString();
                }
                else if (rbTriangle.Checked)
                {
                    double a = double.Parse(txtTriA.Text);
                    double b = double.Parse(txtTriB.Text);
                    double c = double.Parse(txtTriC.Text);

                    double p = (a + b + c) / 2;
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    txtTriPerim.Text = (a + b + c).ToString();
                    txtTriArea.Text = area.ToString("0.00");

                    // Loại tam giác
                    if (a == b && b == c)
                        txtTriType.Text = "Tam giác đều";
                    else if (a == b || a == c || b == c)
                        txtTriType.Text = "Tam giác cân";
                    else if (a * a + b * b == c * c ||
                             a * a + c * c == b * b ||
                             b * b + c * c == a * a)
                        txtTriType.Text = "Tam giác vuông";
                    else
                        txtTriType.Text = "Tam giác thường";
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtCircleR.Clear();
            txtCirclePerim.Clear();
            txtCircleArea.Clear();

            txtSquareA.Clear();
            txtSquarePerim.Clear();
            txtSquareArea.Clear();

            txtRectW.Clear();
            txtRectH.Clear();
            txtRectPerim.Clear();
            txtRectArea.Clear();

            txtTriA.Clear();
            txtTriB.Clear();
            txtTriC.Clear();
            txtTriPerim.Clear();
            txtTriArea.Clear();
            txtTriType.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtCircleArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
