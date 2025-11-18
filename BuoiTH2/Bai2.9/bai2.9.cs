using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LayGiaTri(out double a, out double b)
        {
            bool isA = double.TryParse(txtA.Text, out a);
            bool isB = double.TryParse(txtB.Text, out b);

            if (!isA || !isB)
            {
                MessageBox.Show("Vui lòng nhập đúng số.");
                return false;
            }
            return true;
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double chuVi = 2 * (a + b);
                txtKetQua.Text = chuVi.ToString();
            }
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double dienTich = a * b;
                txtKetQua.Text = dienTich.ToString();
            }
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            if (LayGiaTri(out double a, out double b))
            {
                double duongCheo = Math.Sqrt(a * a + b * b);
                txtKetQua.Text = duongCheo.ToString("0.##");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
