using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, f;

            if (!double.TryParse(txtX.Text, out x))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho x!");
                return;
            }

            // Tính f(x) theo điều kiện
            if (x >= 2)
            {
                f = -8 * Math.Pow(x, 3) - 12 * x - 1;
            }
            else if (x > 1 && x < 2)
            {
                f = Math.Pow(x, 2) - 6 * x - 19;
            }
            else // x <= 1
            {
                f = 7 * x;
            }

            // Hiển thị kết quả
            txtF.Text = f.ToString("0.###");
        }
    }
}
