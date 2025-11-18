using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
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
        private bool LayHaiSo(out int a, out int b)
        {
            bool ktA = int.TryParse(txtA.Text, out a);
            bool ktB = int.TryParse(txtB.Text, out b);

            if (!ktA || !ktB)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên.");
                return false;
            }
            return true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out int a, out int b))
            {
                int tong = a + b;
                MessageBox.Show("Tổng = " + tong.ToString());
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out int a, out int b))
            {
                int hieu = a - b;
                MessageBox.Show("Hiệu = " + hieu.ToString());
            }
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out int a, out int b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0.");
                    return;
                }

                double thuong = (double)a / b;
                MessageBox.Show("Thương = " + thuong.ToString("0.##"));
            }
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out int a, out int b))
            {
                int tich = a * b;
                MessageBox.Show("Tích = " + tich.ToString());
            }
        }
    }
}
