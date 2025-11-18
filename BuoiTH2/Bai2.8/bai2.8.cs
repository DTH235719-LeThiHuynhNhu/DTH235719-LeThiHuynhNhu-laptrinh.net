using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool LayGiaTriNhap(out int a, out int b)
        {
            bool isA = int.TryParse(txtA.Text, out a);
            bool isB = int.TryParse(txtB.Text, out b);

            if (!isA || !isB)
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên.");
                return false;
            }
            return true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (LayGiaTriNhap(out int a, out int b))
                txtKetQua.Text = (a + b).ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            if (LayGiaTriNhap(out int a, out int b))
                txtKetQua.Text = (a - b).ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            if (LayGiaTriNhap(out int a, out int b))
                txtKetQua.Text = (a * b).ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            if (LayGiaTriNhap(out int a, out int b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.");
                    return;
                }

                double thuong = (double)a / b;
                txtKetQua.Text = thuong.ToString("0.##");
            }
        }
    }
}
