using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtNhapN.Text, out n))
            {
                // Kiểm tra số nguyên tố
                if (IsPrime(n))
                {
                    txtKiemTra.Text = $"{n} là số nguyên tố";
                }
                else
                {
                    txtKiemTra.Text = $"{n} không phải số nguyên tố";
                }

                // Tìm các số nguyên tố nhỏ hơn n
                StringBuilder primes = new StringBuilder();
                for (int i = 2; i < n; i++)
                {
                    if (IsPrime(i))
                    {
                        primes.Append(i + " ");
                    }
                }
                txtTimSNT.Text = primes.ToString().Trim();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapN.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapN.Clear();
            txtKiemTra.Clear();
            txtTimSNT.Clear();
            txtNhapN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
