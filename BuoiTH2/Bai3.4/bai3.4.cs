using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (!double.TryParse(txtA.Text, out a) ||
                !double.TryParse(txtB.Text, out b) ||
                !double.TryParse(txtC.Text, out c))
            {
                txtKetQua.Text = "Vui lòng nhập các hệ số hợp lệ!";
                return;
            }

            if (a == 0)
            {
                // Phương trình bậc nhất hoặc vô nghiệm
                if (b == 0)
                {
                    if (c == 0)
                        txtKetQua.Text = "Phương trình vô số nghiệm.";
                    else
                        txtKetQua.Text = "Phương trình vô nghiệm.";
                }
                else
                {
                    double x = -c / b;
                    txtKetQua.Text = $"Phương trình có 1 nghiệm: x = {x}";
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtKetQua.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtKetQua.Text = $"Phương trình có nghiệm kép: x1 = x2 = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKetQua.Text = $"PT có 2 nghiệm: x1 = {x1}; x2 = {x2}";
                }
            }
        }
    }
}
